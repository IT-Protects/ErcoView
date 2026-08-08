# AI context map

Use this to **minimize tokens** while maximizing correctness. Open only what the task needs.

## Task → files

| Task | Open first | Then |
|------|------------|------|
| Login / auth | `Class/clsLogon.vb`, `modMain.vb` | `Forms/frmLogOn.*`, security docs |
| Connection / SQL host | `modMain.vb` (`GetConnectionString`) | `secrets/sql.env` (unlocked), `Forms/frmSettings.vb` |
| Main grid / ribbon | `Class/clsFrmMain.vb` | `Forms/frmMain.vb` (events only), XSD |
| Proposal edit/save | `Class/clsFrmProposal.vb` | `Forms/frmProposal.*`, `Utils.vb`, list handler |
| Multi-select parties | `Class/clsFrmList.vb` | `Utils.vb` |
| Customer | `Class/clsFrmCustomer.vb` | `Forms/frmCustomer.*` |
| Vendor | `Class/clsFrmVendor.vb` + customer | vendor forms |
| Contact | `Class/clsFrmContact.vb` | contact forms |
| Users | `Class/clsFrmUsers.vb` | `frmUser.*`, `frmPassword.*` |
| Job numbers | `Class/clsFrmJobNumbers.vb` | `frmJobNumbers.*` |
| Reports | `Forms/frm*Setup.vb`, `Forms/Reports/rpt*.vb` | XSD report tables |
| Map/KML | `clsFrmMain` map handler, `clsMapIt.vb` | `ErcoViewTemplate.kml` |
| Permissions UI | `modMain.Main` | occasional checks in handlers |
| Data shape | `DataSets/dsErcoView.xsd` | avoid reading entire Designer.vb unless necessary |
| Project/build | `ErcoView.vbproj`, `ErcoView.sln` | `app.config` |
| Secrets policy | `.gitattributes`, `docs/git-crypt.md` | `AGENTS.md` |

## High-cost files (avoid full read)

| File | Why | Strategy |
|------|-----|----------|
| `DataSets/dsErcoView.Designer.vb` | ~20k+ lines generated | Use XSD or search |
| `Forms/*.Designer.vb` | Huge layout | Search control names; edit via small patches |
| `bin/**`, `obj/**` | Build output | Ignore |

## Entry flow anchors

```text
modMain.Main
  → clsLogon.OpenLogOnForm / ValidateUser
  → permission gating
  → clsFrmMain.ShowMainForm
```

## Search cheatsheet

```text
SqlCommand("sp
GetConnectionString
userPermission
Implements IErcoTableHandler
TableAdapter
```

## Doc anchors

| Topic | Doc |
|-------|-----|
| Architecture | `docs/architecture.md` |
| Domain | `docs/domain-model.md` |
| SP list | `docs/reference/stored-procedures.md` |
| Forms map | `docs/reference/forms-and-handlers.md` |
| Ops failures | `docs/troubleshooting.md` |
| Evaluation / roadmap | `EVALUATION-DEEP-DIVE.md` |

## When context is missing

If SP behavior is unclear and `db/` scripts are absent:

1. State assumption explicitly.  
2. Prefer reading client parameter lists over inventing SQL.  
3. Ask for SP definition or add a Training-only probe plan—do not guess GRANT/trigger behavior.
