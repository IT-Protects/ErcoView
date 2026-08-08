# Reference: forms and handlers

Paths relative to `ErcoView/`.

## Pattern

| Piece | Path pattern |
|-------|----------------|
| Form | `Forms/frmX.vb` (+ `.Designer.vb`, `.resx`) |
| Handler | `Class/clsFrmX.vb` or `clsLogon.vb` |
| Reports | `Forms/Reports/rptX.vb` |

## Auth and shell

| Form | Handler / owner | Primary SPs / notes |
|------|-----------------|---------------------|
| `frmLogOn` | `clsLogon` | `spLogin` |
| `frmMain` | `clsFrmMain` | `spGetProposals`, customers, users, vendors, contacts, groups; group insert; reports; map |
| `frmSettings` | code-behind + logon | hosts/paths; `spUpdatePassword` |
| `frmPassword` | used by settings/users | collects new password |
| `frmWelcomeTraining` | logon flow | shown when not Live |

## CRM and parties

| Form | Handler | Primary SPs |
|------|---------|-------------|
| `frmCustomer` | `clsFrmCustomer` | `spGetCustomer`, `spInsertCustomer`, `spUpdateCustomer`, groups |
| `frmVendor` | `clsFrmVendor` → customer | vendor flag / vendor SPs on main grid |
| `frmContact` | `clsFrmContact` | `spGetContact`, `spInsertContact`, `spUpdateContact`, customers list |
| `frmCustomerSelectForEdit` | selection helper | customer pick |
| `frmList` | `clsFrmList` | `spGet*` lists + `spSet*` / `spDelete*` for multi-select |
| `frmUser` | `clsFrmUsers` | `spGetUsers`, `spGetPermissions`, `spInsertUser`, `spUpdateUser` |

## Proposals and jobs

| Form | Handler | Primary SPs |
|------|---------|-------------|
| `frmProposal` | `clsFrmProposal` | `spGetProposals`, `spInsertProposal2`, `spUpdateProposal`, list setters |
| `frmJobNumbers` | `clsFrmJobNumbers` | `spGetJobNumbers`, `spGetNewJobNumber`, `spUpdateJobNumber` |
| `frmBrowse` | proposal docs | filesystem |
| `frmLayoutSave` | layouts | filesystem XML |
| `frmHotSeat` | hot seat view | `spGetProposals` |

## Reports UI

| Form | Role |
|------|------|
| `frmReports` | report menu/entry |
| `frmReportSetup` | generic setup |
| `frmReportViewer` | viewer host |
| `frmBookingsSetup` | year/month → `spGetBookings` |
| `frmCompletedProjectsSetup` | year → completed / const schedule SPs |

## Report classes (`Forms/Reports/`)

| Report | Typical data SP |
|--------|-----------------|
| `rptBookings` / `XtraReportBookings` | `spGetBookings` |
| `rptCompletedProjects` | `spRptCompletedPrj` |
| `rptConstSch` / `rptConstSched` / `rptConstForcast` | `spRptConstSch` / `spRptConstSch2` |
| `rptRevenueReport` | `spReportRevenueByMonth` |
| `rptProposalByMonth` | `spGetProposalsByMonth` |
| `rptHotSeat` | `spGetProposals` |
| `rptNOR` | proposal-based |
| `rptOrderReceived` | proposal-based |
| `XtraReportProposal` | proposal-based |

## Utilities (no form)

| Class | Role |
|-------|------|
| `modMain` | Entry, globals, connection, proposal number, layouts |
| `Utils` | ID→name and proposal party resolution SPs |
| `clsMapIt` / `clsKmlMaker` | KML generation |
| `clsBase` / `IErcoTableHandler` | CRUD contract |
| `TreeListOperationFindNodeByText` | DevExpress tree helper |

## Designer files

`*.Designer.vb` are generated/maintained by VS designers. Prefer edits through the designer for layout; avoid hand-merging unless necessary.
