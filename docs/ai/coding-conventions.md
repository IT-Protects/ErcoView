# AI coding conventions

Machine-actionable rules for edits in this repo.

## Language and framework

- Language: **VB.NET**  
- Framework: **.NET Framework 4.0** — do not introduce APIs requiring newer frameworks without an explicit retarget task  
- UI: **WinForms + DevExpress 12.2** — do not swap control libraries casually  
- `Option Strict` is Off historically; still avoid late-bound mess in new code  

## Structure rules

1. **Business logic in `Class/`**, not in form event handlers when a handler already exists.  
2. Forms **raise events**; handlers **handle events**.  
3. New CRUD entity: implement `IErcoTableHandler` via `clsBase` unless there is a strong reason not to.  
4. Vendor-like reuse: prefer inheritance/flags over copy-paste (see `clsFrmVendor`).  

## Data access rules

```vb
' Preferred
Using connection As New SqlConnection(GetConnectionString())
    connection.Open()
    Dim cmd As New SqlCommand("spName", connection) With {
        .CommandType = CommandType.StoredProcedure
    }
    cmd.Parameters.AddWithValue("@p", value)
    cmd.ExecuteNonQuery()
End Using
```

- **Do** use stored procedures + parameters.  
- **Do** assign TableAdapter.Connection from `GetConnectionString()` before Fill.  
- **Don't** concatenate user input into SQL text.  
- **Don't** hardcode SQL passwords or users—use `secrets/sql.env`.  

## Secrets rules

- Paths in `.gitattributes` with `filter=git-crypt` must remain encrypted in Git.  
- After adding a new secret path pattern, update `.gitattributes` **before** first add.  
- Verify: `git-crypt status` and `git check-attr filter <file>`.  
- Never write real secrets into `docs/` or issues.  

## Naming

| Kind | Pattern | Example |
|------|---------|---------|
| Form | `frmX` | `frmProposal` |
| Handler | `clsFrmX` | `clsFrmProposal` |
| Report | `rptX` / `XtraReportX` | `rptBookings` |
| SP | `spVerbNoun` | `spUpdateProposal` |
| Module globals | descriptive camel/Pascal as existing | `userPermission` |

## UI / DevExpress

- Match existing control types on the same form.  
- Do not upgrade DevExpress version in a drive-by change.  
- Be careful with `.resx` and Designer diffs—keep them intentional.  

## Error handling

- Existing code uses `MsgBox(ex.Message)` widely.  
- New code: at least use `Using` for connections; avoid empty `Catch`.  
- Do not surface passwords in messages.  

## Permissions

When adding features that create/update sensitive data:

- Gate UI with `userPermission` consistently with nearby actions.  
- Document that SQL-side enforcement may be absent.  

## Comments and dead code

- Prefer deleting obsolete commented credential samples.  
- Keep SP parameter lists aligned with SQL; don't leave half-migrated insert paths without notes.  

## Docs sync

If you change:

| Change | Update |
|--------|--------|
| New SP call | `docs/reference/stored-procedures.md` |
| New form/handler | `docs/reference/forms-and-handlers.md` |
| Auth/secrets | `docs/security.md`, `docs/git-crypt.md` |
| User workflow | `docs/ui-and-workflows.md` |
| Agent rules | `AGENTS.md` |

## Files agents should rarely rewrite wholesale

- `*.Designer.vb`  
- `dsErcoView.Designer.vb`  
- `*.resx` (unless required)  
- `bin/**`, `obj/**`  
