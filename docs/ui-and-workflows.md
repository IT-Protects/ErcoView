# UI and workflows

## Shell: main form

After login, `frmMain` is the application shell:

- **Ribbon** pages switch entity grids  
- **Grids** are DevExpress; layouts can be saved/loaded  
- **Actions** open modal detail forms or reports  

Default landing: **Proposals**.

## Primary workflows

### Log on

1. Enter username / password.  
2. Select **Training|Live** and **Local|Remote**.  
3. Optional **Settings** (hosts, folders) — available from logon.  
4. On success: permission-based ribbon adjustments; Training may show welcome dialog.

### Manage proposals

1. Open Proposals page (default).  
2. Grid loads `spGetProposals` (id `0` = list).  
3. **New** → allocate number (`spGetNewProposalNumber`) → proposal form.  
4. **Edit** → `clsFrmProposal` loads row by id.  
5. Multi-select lists (customers, contacts, …) via `clsFrmList` (max 3).  
6. **Save** → `spInsertProposal2` or `spUpdateProposal`.  
7. Optional: folder browse, map export, reports on selection.

### Manage customers / vendors / contacts

1. Select ribbon page.  
2. Grid fill for that entity.  
3. New/Edit opens corresponding form/handler.  
4. Vendor path reuses customer logic with vendor flag.

### Users (Admin)

1. Users page visible only for permission 1.  
2. Create/update via `spInsertUser` / `spUpdateUser`.  
3. Password change UI writes password field (historically plaintext store).

### Job numbers

Dedicated form for listing and minting job numbers through job-number SPs.

### Reports

1. Choose report from main UI.  
2. Setup form may ask year/month.  
3. Report binds to SP result and DevExpress preview/print.

### Map selected proposals

1. Select one or more proposal grid rows with GPS.  
2. Map action builds KML from `ErcoViewTemplate.kml`.  
3. External association opens the KML file.

### Layouts

Grid layouts saved as XML under local path or role folder on server share (`Admin` / `General` / `Super`).

## Permission impact on UI

| Permission | Notable restrictions |
|------------|----------------------|
| Admin (1) | None of the client-side restrictions below |
| General (2) | No Users page; New Customer disabled; New Vendor enabled |
| Super (3) | New Proposal disabled; some folders hidden in browse; super layouts |

Exact button names live in `frmMain` / `modMain` permission block.

## Form inventory (summary)

Full mapping: [reference/forms-and-handlers.md](reference/forms-and-handlers.md).

| Area | Forms |
|------|--------|
| Auth / shell | `frmLogOn`, `frmMain`, `frmSettings`, `frmPassword`, `frmWelcomeTraining` |
| CRM | `frmCustomer`, `frmVendor`, `frmContact`, `frmCustomerSelectForEdit` |
| Proposal | `frmProposal`, `frmList`, `frmBrowse`, `frmLayoutSave`, `frmHotSeat` |
| Jobs | `frmJobNumbers` |
| Users | `frmUser` |
| Reports setup | `frmReports`, `frmReportSetup`, `frmReportViewer`, `frmBookingsSetup`, `frmCompletedProjectsSetup` |

## UX conventions (for changers)

- Prefer existing DevExpress control types on a form.  
- Raise events from the form; handle in `clsFrm*`.  
- Use `MsgBox` / `MessageBox` only consistent with surrounding code (or introduce logging carefully).  
- Keep Training banner awareness when adding destructive actions.
