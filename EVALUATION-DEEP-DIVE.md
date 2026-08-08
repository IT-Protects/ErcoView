# ErcoView — Deep Dive (Security · Bug Fixes · DB Map · Modernization)

**Date:** 2026-08-08  
**Codebase:** `C:\Users\SamuelPearson\grok\ErcoView`  
**App version:** 20.9.28 · **Stack:** VB.NET WinForms · .NET Framework 4.0 · DevExpress 12.2

This document expands evaluation items **1–4**. Bug fixes from item 2 are already applied in source (see §2).

---

## 1. Security hardening plan

### 1.1 Threat model (current)

| Threat | How it works today | Impact |
|--------|--------------------|--------|
| Shared SQL login in source | `GetConnectionString()` embeds `User ID=ercoviewuser;Password=!ercoView1` | Anyone with the binary or repo can open Live/Training DB |
| Public remote host | `My.Settings.remoteIP` default `207.91.146.7` | Internet-facing SQL if port open |
| App passwords in cleartext | `spLogin` returns `PASSWORD`; client compares strings | Password dump via SP, grid, or SQL |
| Password in user grid | `spGetUsers` maps `PASSWORD` column into DataSet | Admins see plaintext in UI/data |
| UI-only authorization | `userPermission` only enables/hides buttons | Any SQL user can call any SP |
| Settings unrestricted | Logon **Settings** reachable before auth; SQL host editable | Host pivot / credential misuse |
| Exception dialogs | `MsgBox(ex.Message)` | Info disclosure (server names, SQL text) |
| Commented secrets | Old Portal password + sample user/pass in comments | Credential archaeology |

### 1.2 Current auth flow (as implemented)

```
frmLogOn
  → clsLogon.ValidateUser
      → isDatabaseLive / isLocalDatabase from combos
      → GetConnectionString()  // hardcoded SQL user
      → spLogin(@userName)    // returns row including password + permission
      → client: myPassword <> myTestPassword
      → sets globals: currentErcoViewUserID, userPermission, ...
  → modMain gates UI buttons by userPermission
  → all later CRUD uses same shared SQL login
```

**Permissions (UI only):**

| ID | Role | Observed UI rules |
|----|------|-------------------|
| 1 | Admin | Full; Users page; layout Admin folder |
| 2 | General | No Users page; no New Customer (New Vendor re-enabled); layout General |
| 3 | Superintendent | No New Proposal; layout Super; browse folder restrictions |

There is **no** per-SP permission check and **no** row-level security in the client.

### 1.3 Phase A — Immediate (hours–days, no redesign)

Do these **before** sharing the repo or exposing remote SQL.

| # | Action | Owner | Notes |
|---|--------|-------|-------|
| A1 | **Rotate** SQL password for `ercoviewuser` (and any legacy Portal user) | DBA | Assume current password is compromised |
| A2 | **Firewall** remote SQL: allow only VPN / known office IPs; prefer close public 1433 | Infra | Confirm `207.91.146.7` exposure |
| A3 | Remove passwords from **source**; load from environment / encrypted config / Windows DPAPI | Dev | See A4 pattern |
| A4 | Prefer **Windows Integrated Security** for LAN; SQL auth only over VPN with least privilege | DBA+Dev | Aligns with old design-time strings |
| A5 | Strip commented credentials (`clsLogon` TEMP, `modMain` Portal comment) | Dev | Hygiene |
| A6 | Stop shipping **plaintext password** in grids: remove `PASSWORD` from `spGetUsers` result used by UI | DBA+Dev | Password change uses dedicated form already |
| A7 | Audit who has MSI/binaries; treat as credential carriers | Ops | `bin\` embeds same config |

**Target connection string shape (after A3/A4):**

```text
# Preferred (LAN)
Data Source={localServer};Initial Catalog=ErcoView_Live;Integrated Security=True;Application Name=ErcoView

# Remote over VPN (if SQL auth still required)
Data Source={remote};Initial Catalog=ErcoView_Live;User ID=...;Password=...;  # password NOT in repo
```

**Where to store secrets (WinForms practical options):**

1. **User/machine config outside repo** + installer sets values  
2. **Windows Credential Manager** (`CredentialManagement` / DPAPI)  
3. Environment variables for IT-managed desktops  
4. Avoid encrypting `app.config` with a key that ships in the same binary (false security)

### 1.4 Phase B — Password hashing (1–2 weeks with DB change)

**Goal:** Never store or return reversible passwords.

| Step | Change |
|------|--------|
| B1 | Add columns `PASSWORD_HASH`, `PASSWORD_SALT` (or single `PASSWORD_HASH` with embedded salt, e.g. PBKDF2/bcrypt) |
| B2 | One-time migration: hash existing plaintext; clear `PASSWORD` |
| B3 | Replace `spLogin` with verify-hash procedure: input `@userName`, `@password` → return user row **without** secret, or return success + claims only |
| B4 | Client: send password only as SP parameter; **never** compare locally |
| B5 | `spUpdatePassword` / `spInsertUser` / `spUpdateUser`: accept plain once, hash **inside SP or app** before write; never SELECT hash into UI |
| B6 | Force password change for all users after cutover |
| B7 | Policy: min length, no default `eV1234`-style samples |

**Client login sketch (after B):**

```vb
' Bad (today)
dr = spLogin(userName) → compare password in app

' Good
ok = spAuthenticate(userName, password) → returns UserId, FullName, PermissionId only
```

Use **PBKDF2** (`Rfc2898DeriveBytes`) if staying on .NET 4.x without extra packages; work factor ≥ 100k iterations.

### 1.5 Phase C — Authorization & least privilege (2–4 weeks)

| Step | Change |
|------|--------|
| C1 | Map roles to **SQL roles** or separate logins (e.g. `ErcoView_Admin`, `ErcoView_User`) with GRANT EXECUTE only on allowed SPs |
| C2 | Or single app login but **SPs enforce** `@actingUserId` + permission lookup for writes |
| C3 | Pass `currentErcoViewUserID` into every insert/update; reject if permission insufficient |
| C4 | Hide Settings SQL host fields from non-admin; require auth before Settings |
| C5 | Remove password field from user edit form for non-admin “reset” flows; use dedicated reset SP |
| C6 | Structured logging (file/event log) instead of raw SQL errors to users |

**Minimum SP permission matrix (suggested):**

| Capability | Admin | General | Super |
|------------|:-----:|:-------:|:-----:|
| Login / change own password | ✓ | ✓ | ✓ |
| CRUD proposals | ✓ | ✓ | R / limited |
| New proposal | ✓ | ✓ | ✗ |
| Users admin | ✓ | ✗ | ✗ |
| Customers create | ✓ | ✗ | ✗ |
| Vendors create | ✓ | ✓ | ✗ |
| Reports | ✓ | ✓ | ✓ (maybe limited) |
| Job number mint | ✓ | ✓ | ? |

### 1.6 Phase D — Network & data-at-rest

| Item | Recommendation |
|------|----------------|
| Remote access | Site-to-site or client VPN only; no naked SQL on public IP |
| TLS | Enable Force Encryption on SQL; trust server cert properly |
| Backups | Encrypt backup media; Training DB must not be a copy of Live without scrubbing if shared |
| File shares | Layout paths `\\sbs01\...` / proposal folders: ACL by AD group |
| Audit | SQL Server Audit or Extended Events on `spUpdateProposal`, user tables |

### 1.7 Acceptance criteria (security)

- [ ] No secrets in git or MSI  
- [ ] `spLogin` does not return password material  
- [ ] Passwords stored only as salted hashes  
- [ ] Remote SQL not reachable from public internet  
- [ ] Write SPs reject unauthorized permission levels  
- [ ] Password rotation runbook documented  

---

## 2. Bug fixes applied + related defect backlog

### 2.1 Fixed in this pass

#### Bug 2.1 — Logon location never selected “Local” correctly

**File:** `Class\clsLogon.vb`  
**Symptom:** After choosing Remote, switching back to Local could leave `isLocalDatabase = False` because the code tested **`cbDatabase.Text = "Local"`**, but Local/Remote live on **`cbLocation`** (items: Local, Remote). Database combo is Training/Live only.

**Fix:** Drive flags from `SelectedIndex` (aligned with `SaveSettings` / form load):

```vb
isDatabaseLive = (oFrmLogon.cbDatabase.SelectedIndex = 1)   ' Live
isLocalDatabase = (oFrmLogon.cbLocation.SelectedIndex = 0)  ' Local
```

**Test:**

1. Log on Local + Training → title shows TRAINING; connects to `localIP` + `ErcoView_Training`  
2. Log on Local + Live → LIVE + `ErcoView_Live`  
3. Log on Remote + Live → uses `remoteIP`  
4. Toggle Remote → Local in one session (if re-login) → host returns to local  

#### Bug 2.2 — Customer slot #2 dropped in proposal multi-customer resolve

**File:** `Class\Utils.vb` → `GetCustomerOfProposal`  
**Symptom:** Output params for customers 1/2/3; param2 was assigned to **`customerId3`**, overwriting/losing customer #2.

**Fix:** Assign to `customerId1/2/3` respectively; use `DBNull` checks + `CInt` instead of string `"Null"`.

**Test:** Proposal with three customers → display/lookup shows all three names/IDs.

### 2.2 Related defects (not yet fixed — recommended backlog)

| ID | Severity | Location | Issue |
|----|----------|----------|--------|
| D1 | High | `Utils.*OfProposal` | Same fragile `"Null"` string checks; possible silent zero IDs |
| D2 | Medium | `Utils.GetTextStringFromIDs` | N+1: up to ~6 SP round-trips per multi-field resolve |
| D3 | Medium | `app.config` | 10+ duplicate connection strings; Training named string points at Live catalog |
| D4 | Medium | Dead EF string | `ErcoView_LiveEntities` → missing `Model1` |
| D5 | Low | Typos | `ONE_CALL_EXPERATION_DATE`, “sucessfully” — may match DB column names; change carefully |
| D6 | Medium | `clsFrmList` | `spDeleteCompanyFromProposal` reused for group/customer/contact — verify param semantics |
| D7 | Low | Global state | `currentErcoViewUserID = 1` default before login |
| D8 | Medium | Auth | Password column still in `spGetUsers` DataSet |
| D9 | Low | `spInsertProposal3` | Commented alternate path; confirm which SP is production |
| D10 | Medium | No optimistic concurrency | Proposal update has no rowversion; last-write-wins |

---

## 3. Database dependency map

> **Important:** Table DDL and SP bodies are **not in this repo**. The map is inferred from TableAdapters (`dsErcoView.xsd`), direct `SqlCommand` calls, and UI fields. Confirm against a Live/Training script export.

### 3.1 Databases & hosts

| Catalog | Purpose | Selected when |
|---------|---------|----------------|
| `ErcoView_Live` | Production | Logon Database = Live |
| `ErcoView_Training` | Sandbox | Logon Database = Training |

| Host setting | Setting key | Default (config) |
|--------------|-------------|------------------|
| Local SQL | `localIP` | `SQL01` (settings); design-time often `ICES3\SQL_BT` |
| Remote SQL | `remoteIP` | `207.91.146.7` |
| Historical | app.config | `ICES3\SQL_BT`, `ICES2\SQL_PROJECTS` |

Runtime always uses **`GetConnectionString()`** (SQL auth user), not the Integrated Security design-time strings—except designers/TableAdapters may still bake design-time connection metadata.

### 3.2 Complete stored-procedure inventory

#### A. Auth & users

| Procedure | Direction | Used by | Params / notes |
|-----------|-----------|---------|----------------|
| `spLogin` | R | `clsLogon` | `@userName` → reader: id, names, password, permission… |
| `spGetUsers` | R | Main grid, user form | `@userID` (0 = all?) |
| `spGetUserById` | R | Utils | `@id` → `@fname`, `@lname` out |
| `spInsertUser` | W | `clsFrmUsers` | names, userName, **password**, email, permission, flags |
| `spUpdateUser` | W | `clsFrmUsers` | same |
| `spUpdatePassword` | W | `frmSettings` | `@userID`, `@password` |
| `spGetPermissions` | R | User form combo | PERMISSION_ID, PERMISSION |

#### B. Proposals (core)

| Procedure | Direction | Used by |
|-----------|-----------|---------|
| `spGetProposals` | R | Main grid, reports, hot seat (`@id` 0=list) |
| `spGetNewProposalNumber` | R | `modMain` | out `@newProposal` |
| `spInsertProposal2` | W | `clsFrmProposal` | full field list |
| `spInsertProposal3` | W | commented legacy |
| `spUpdateProposal` | W | `clsFrmProposal` | ~80 parameters |
| `spGetProposalsByMonth` | R | Report |
| `spGetSalesmanOfProposalId` | R | Utils |
| `spGetCustomerOfProposalId` | R | Utils |
| `spGetContactOfProposalId` | R | Utils |
| `spGetVendorOfProposalId` | R | Utils |
| `spGetSuperOfProposalId` | R | Utils |
| `spGetJobTypeOfProposalId` | R | Utils |
| `spGetSBSOfProposalId` | R | Utils |
| `spSetSalesman` / `spDeleteSalesman` | W | List picker |
| `spSetSuper` / `spDeleteSuper` | W | List picker |
| `spSetContact` / `spSetCustomer` / `spSetGroup` / `spSetVendor` | W | List picker |
| `spDeleteCompanyFromProposal` | W | List picker (shared delete) |
| `spSetJobTypes` / `spDeleteJobTypes` | W | Job type multi-select |

#### C. Customers / vendors / contacts / groups

| Procedure | Direction | Used by |
|-----------|-----------|---------|
| `spGetCustomer` / `spGetCustomers` | R | Grids, pickers |
| `spGetCustomerById` | R | Utils |
| `spInsertCustomer` / `spUpdateCustomer` | W | `clsFrmCustomer` (+ vendor via flag) |
| `spGetVendor` / `spGetVendors` | R | Grids |
| `spGetVendorById` | R | Utils |
| `spGetContact` / `spGetContacts` | R | Grids (`spGetContacts` takes proposal customer ids) |
| `spGetContactById` | R | Utils |
| `spInsertContact` / `spUpdateContact` | W | `clsFrmContact` |
| `spGetGroups` | R | Grids / customer groups |
| `spInsertGroup` | W | Main form |
| `spGetGroupOfCustomerId` | R | Utils |

#### D. Lookups

| Procedure | Direction | Used by |
|-----------|-----------|---------|
| `spGetSalesman` | R | List |
| `spGetSalesmanById` | R | Utils |
| `spGetSuper` / `spGetSuperById` | R | List / Utils |
| `spGetJobTypes` / `spGetJobNameById` | R | List / Utils |
| `spGetJobNumbers` | R | Job numbers form |
| `spGetNewJobNumber` | R | Job numbers |
| `spUpdateJobNumber` | W | Job numbers |

#### E. Reports

| Procedure | Direction | Report / form |
|-----------|-----------|---------------|
| `spGetBookings` | R | Bookings (`year`, `month`) |
| `spRptCompletedPrj` | R | Completed projects (`year`) |
| `spRptConstSch` | R | Construction schedule |
| `spRptConstSch2` | R | Const schedule variant / forecast |
| `spReportRevenueByMonth` | R | Revenue |
| `spGetProposals` | R | NOR, Hot Seat, Order Received, Proposal-by-month (some) |

*(XtraReport types may share the same adapters.)*

### 3.3 Logical entities (inferred tables)

SP names and result shapes imply roughly:

```
USERS / PERMISSIONS
CUSTOMERS  ↔  GROUPS (M:N or denormalized GROUP_TEXT)
CONTACTS   →  CUSTOMER_ID
VENDORS    (parallel shape to customers; app uses isVendor flag)
JOB_TYPES
JOB_NUMBERS
PROPOSALS  (wide row; GPS, prices, permits, status fields)
  ├─ PROPOSAL_SALESMAN (or SALESMAN_ID1..3 columns)
  ├─ PROPOSAL_CUSTOMER
  ├─ PROPOSAL_CONTACT
  ├─ PROPOSAL_VENDOR
  ├─ PROPOSAL_SUPER
  └─ PROPOSAL_JOB_TYPE
```

**Evidence of “3 slots” design:** insert/update proposal passes `*_ID1..3`; Utils has parallel `*OfProposalId` procs. DB may use either denormalized columns or junction tables behind those SPs.

### 3.4 Core result shapes

#### Users (`spGetUsers`)

`USER_ID, LAST_NAME, FIRST_NAME, USER_NAME, PASSWORD, EMAIL, PERMISSION, SALESMAN, SUPER, PERMISSION_ID, ACTIVE`

#### Customer (`spGetCustomer`)

`CUSTOMER_ID, CUSTOMER_NAME, ADDRESS_*, CITY, COUNTY, STATE, PHONE, FAX, WEBSITE, ZIP_CODE, CUSTOMER_NOTES, GROUP_TEXT, customer_type, ACTIVE`

#### Contact (`spGetContact`)

`CONTACT_ID, FIRST_NAME, LAST_NAME, ADDRESS_*, CITY, ZIP, COUNTY, STATE, PHONE, PHONE2, FAX, EMAIL, CUSTOMER_ID, CUSTOMER_NAME, WEBSITE, NOTES, ACTIVE`

#### Proposal list/detail (`spGetProposals`) — 70+ columns

Includes: IDs/numbers, denormalized `*_TEXT` fields, dates (proposal/NOR/completed/updated), GPS_N/W, pricing (proposal/permit/extra/actual/total/profit), one-call ticket fields, priority, permit/contract/job status, SBS_COMPANY, est/act work days, ACTIVE_STATUS, etc.

#### Bookings (`spGetBookings`)

`PROPOSAL_ID, PROPOSAL_NUMBER, JOB_NUMBER, date_nor, DESCRIPTION, STATUS, COUNTY, NOR_MONTH/YEAR, SALESMAN_TEXT, CUSTOMER_TEXT, PRICE_TOTAL, JOB_STATUS, price_*, BOOK_PRICE`

### 3.5 Non-SQL dependencies

| Dependency | Config / path | Used for |
|------------|---------------|----------|
| Layout local | `layoutPathLocal` = `C:\ErcoView\Layouts` | DevExpress grid layouts |
| Layout server | `layoutPathServer` = `\\sbs01\er-con\Layouts` + Admin/General/Super | Shared layouts |
| Proposal folders | `browseFolder` / `erconBrowseFolder` | File browser, template copy |
| KML template | `ErcoViewTemplate.kml` next to EXE | Google Earth export |
| DevExpress 12.2 | GAC/install or `bin\` | UI + reports |

### 3.6 Recommended DB extraction script (run on SQL Server)

```sql
-- Catalogs
SELECT name FROM sys.databases WHERE name LIKE 'ErcoView%';

-- All ErcoView procedures
SELECT ROUTINE_SCHEMA, ROUTINE_NAME
FROM ErcoView_Live.INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE'
ORDER BY ROUTINE_NAME;

-- Script definitions (SSMS: Tasks → Generate Scripts)
-- Or:
SELECT m.definition
FROM ErcoView_Live.sys.sql_modules m
JOIN ErcoView_Live.sys.objects o ON m.object_id = o.object_id
WHERE o.type = 'P'
ORDER BY o.name;

-- Tables + FKs
SELECT * FROM ErcoView_Live.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';
SELECT * FROM ErcoView_Live.INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS;
```

Store output under `db\schema\` in source control (without data/secrets).

### 3.7 Call graph (simplified)

```
modMain.Main
  └─ clsLogon → spLogin
  └─ clsFrmMain
       ├─ spGetProposals / Customer / Users / Vendor / Contact / Groups
       ├─ spInsertGroup
       ├─ → clsFrmProposal → spGetProposals, spInsertProposal2, spUpdateProposal
       │        └─ clsFrmList → spGet*/spSet*/spDelete*
       │        └─ Utils → *ById / *OfProposalId  (many)
       ├─ → clsFrmCustomer/Vendor → spInsert/UpdateCustomer, spGetCustomer
       ├─ → clsFrmContact → spInsert/UpdateContact
       ├─ → clsFrmUsers → spInsert/UpdateUser, spGetUsers, spGetPermissions
       ├─ → clsFrmJobNumbers → spGetJobNumbers, spGetNewJobNumber, spUpdateJobNumber
       └─ Reports → spGetBookings, spRpt*, spReportRevenueByMonth, spGetProposals*
```

---

## 4. Modernization roadmap

### 4.1 Decision framework

| If you need… | Prefer… |
|--------------|---------|
| Keep desktop users, low budget, SQL stays on-prem | **Path K — Keep-alive** |
| Security fixes + 5+ years life, still WinForms | **Path M — Modernize in place** |
| Web/mobile, multi-site, new UX, API integrations | **Path R — Rewrite** |
| Uncertain | **Path K then spike R** after DB schema export |

Rough cost (order of magnitude, 1 senior + domain expert):

| Path | Effort | Risk | Outcome |
|------|--------|------|---------|
| K Keep-alive | 1–3 weeks | Low | Secure enough to keep running |
| M In-place modernize | 2–4 months | Medium | .NET 4.8, cleaner config, better auth, maybe DevExpress upgrade |
| R Rewrite | 6–12+ months | High (reports) | Web or modern desktop; SP layer reusable |

Domain logic is only ~**4k LOC**; risk is **reports + DevExpress UX + SP behavior fidelity**.

### 4.2 Path K — Keep-alive (recommended first)

**Goal:** Safe operation without feature work.

1. Apply §1 Phase A (secrets, firewall, rotate)  
2. Ship bug fixes (logon + customerId2) — **done in tree**  
3. Document runbook: hosts, Live/Training, layout shares, install MSI  
4. Export full DB schema + SP scripts to repo (`db\`)  
5. Pin a build machine image with VS + DevExpress 12.2  
6. Stop dual-writing connection strings; one runtime path  

**Exit criteria:** New hire can restore DB + run EXE against Training.

### 4.3 Path M — Modernize in place

#### M1. Framework (1–2 weeks)

| Task | Detail |
|------|--------|
| Retarget | .NET Framework **4.8** (`TargetFrameworkVersion`) |
| Tooling | Open in VS 2022; fix any API warnings |
| Binding redirects | Expect DevExpress / SQLClient redirects |
| Test | Full regression on Training |

#### M2. Configuration & DI-lite (1–2 weeks)

| Task | Detail |
|------|--------|
| Single connection factory | Replace 10 app.config strings |
| Environment profiles | Debug→Training, Release→Live optional |
| Remove dead EF Model1 string | |
| Settings hardening | Admin-only SQL host edit |

#### M3. Security (§1 B+C) (2–4 weeks)

Hash passwords, lock down SPs, least-privilege SQL.

#### M4. Code hygiene (ongoing)

| Task | Detail |
|------|--------|
| `Option Strict On` | File-by-file |
| `Using` everywhere for connections | |
| Central error logger | No raw SQL to MsgBox in production |
| Fix Utils N+1 | One SP returning display names |
| Thin handlers | Extract `ProposalService` from `clsFrmProposal` |

#### M5. DevExpress decision (major fork)

| Option | Pros | Cons |
|--------|------|------|
| **Stay on 12.2** | No license/UI churn | Unsupported; hard to hire |
| **Upgrade DevExpress** | Supported grids/reports | License cost; API breaks; retest all reports |
| **Replace UI toolkit** | Long-term freedom | Essentially a rewrite of Forms |

Recommendation: if Path M only, **budget DevExpress upgrade or accept 12.2 freeze** with runtime DLLs in repo (`lib\devexpress\`) and legal license check.

#### M6. Installer

Replace `.vdproj` with **WiX**, **Advanced Installer**, or **MSIX**. Publish ClickOnce only if domain-joined and update story is needed.

#### M7. Source control

- Remove TFS bindings from `.sln`  
- Git + `.gitignore` (`bin/`, `obj/`, `.vs/`, user files)  
- Optional: Git LFS not needed if DevExpress stays NuGet/local lib  

### 4.4 Path R — Rewrite (strategic)

**Reuse:** SQL Server databases + most stored procedures as the service boundary.  
**Replace:** WinForms + DevExpress UI + client-side auth.

#### Suggested architecture

```
[Browser / MAUI / WPF]
        │ HTTPS
[ASP.NET Core API]  ── JWT / Windows Auth / Entra ID
        │
[Application services]  Proposal, Customer, Report
        │
[ADO.NET / Dapper] → existing SPs  (or gradual EF Core for new tables)
        │
[SQL Server ErcoView_Live / _Training]
```

#### Module migration order (strangle pattern)

1. **Read-only proposal list + detail** (highest use)  
2. **Auth** (Entra ID or ASP.NET Identity + hashed local users)  
3. **Proposal create/edit** (parity with `spUpdateProposal` fields)  
4. **Customers / contacts / vendors**  
5. **Reports** (use SSRS, RDLC, or embedded HTML/PDF libraries—biggest effort)  
6. **Job numbers, lists, settings**  
7. **Maps** (replace KML/Google Earth with Leaflet/Mapbox)  
8. **Deprecate desktop EXE**

#### Stack options

| UI | When |
|----|------|
| Blazor Server | Internal LAN, fast desktop-like |
| React/Vue + API | Multi-site, separate frontend team |
| WPF / WinUI + API | Users insist on thick client |
| Power Apps / Dynamics | If org standardizes on M365 (heavy process fit needed) |

#### Report strategy

- Short term: keep DevExpress reports in a **report microservice** or hang desktop report EXE off API  
- Long term: SSRS or QuestPDF/FastReport with SQL views matching current SP outputs  

### 4.5 Phased timeline (example)

```
Week 0-2     Path K: security A + bugfix + schema export
Week 3-6     Path M1–M3: .NET 4.8 + secrets + password hash
Week 7-12    Path M4–M6: hygiene + installer + (optional) DX upgrade
Month 4+     Path R spike: API + proposal list/detail read
Month 6-12   Path R: write paths + reports + cutover
```

### 4.6 What not to do

- Full rewrite **without** SP/schema inventory  
- Big-bang DevExpress + .NET Core migration in one PR  
- Storing new secrets in `app.config` “temporarily”  
- Changing `ONE_CALL_EXPERATION_*` column names without DB migration  
- Enabling public SQL “for remote users” without VPN  

### 4.7 Success metrics

| Metric | Target |
|--------|--------|
| Secrets in repo | 0 |
| Login fails open (wrong host) | 0 regressions after logon fix |
| Multi-customer display | 3/3 customers shown |
| Build on clean VM | Documented + reproducible |
| Mean time to restore Training | < 1 day with docs |
| Critical SP coverage in tests | Login, Get/Update Proposal, Insert User |

---

## 5. Immediate next actions (checklist)

**Security**

1. Rotate `ercoviewuser` password; close public SQL if open  
2. Remove hardcoded password from `modMain.GetConnectionString` (use config outside git)  
3. Plan `spLogin` hash verify  

**Correctness**

4. ~~Fix logon Local/Remote~~ **done**  
5. ~~Fix customerId2~~ **done**  
6. Regression test on Training DB  

**Knowledge**

7. Run §3.6 scripts; commit schema under `db\`  
8. Confirm SP list matches production (Training may lag Live)  

**Strategy**

9. Choose Path K vs M vs R with stakeholders  
10. License check: DevExpress 12.2 redistribution rights  

---

## 6. Files touched in this evaluation pass

| File | Change |
|------|--------|
| `ErcoView\Class\clsLogon.vb` | Logon Live/Local flags via SelectedIndex |
| `ErcoView\Class\Utils.vb` | `GetCustomerOfProposal` Id2/Id3 + null handling |
| `EVALUATION-DEEP-DIVE.md` | This document |

No installer or app.config secret rotation was applied (requires ops credentials and deliberate deploy plan).
