# Development

## Toolchain

| Tool | Role |
|------|------|
| Visual Studio (with VB) | Build / design forms |
| .NET Framework 4.0 targeting | Project target |
| DevExpress 12.2 | Controls + reports |
| SQL Server + SSMS | SP development |
| Git + git-crypt | Source + secrets |
| Optional GitHub | `IT-Protects/ErcoView` |

`Option Strict` is **Off** project-wide historically—prefer strict typing in new code when possible.

## Branching and PR hygiene

1. Branch from `main`.  
2. Unlock git-crypt locally.  
3. Prefer Training DB for all functional testing.  
4. Do not commit key files or plaintext secret expansions outside encrypted paths.  
5. PR description: what / why / test notes (Live vs Training).  
6. Avoid drive-by reformatting of huge Designer files.

## Where to change what

| Goal | Primary location |
|------|------------------|
| Business rules on a screen | `Class/clsFrm*.vb` |
| Control layout | `Forms/*.vb` + Designer |
| New grid column from SP | SQL SP + refresh DataSet XSD + UI bind |
| Login / connection | `clsLogon.vb`, `modMain.vb`, `secrets/sql.env` |
| Shared name resolution | `Utils.vb` (watch N+1) |
| Report | `Forms/Reports/*`, setup form, SP |
| Permissions gating | `modMain.Main`, sometimes form handlers |

## Coding conventions

See also [ai/coding-conventions.md](ai/coding-conventions.md).

- Keep forms event-thin; handlers own SQL.  
- Use `CommandType.StoredProcedure` and parameters—no string-concat SQL.  
- Prefer `Using` for `SqlConnection`.  
- Match existing naming: `clsFrmX`, `frmX`, `spName`.  
- Preserve intentional DB typos in column names unless migrating SQL.  
- git-crypt for any new secret file; update `.gitattributes` if new patterns needed.

## DataSet / TableAdapter changes

1. Change SP on SQL Server (Training first).  
2. Update `dsErcoView.xsd` via designer or careful edit.  
3. Rebuild; fix bind sites.  
4. Expect large Designer diffs—call that out in PRs.

## Local run configuration

1. `git-crypt unlock`  
2. Valid `secrets/sql.env`  
3. Settings hosts reachable  
4. DevExpress installed  
5. Start with Training + Local  

## Debugging tips

- Break on `GetConnectionString` to verify host/catalog.  
- Break on `clsLogon.ValidateUser` for auth issues.  
- For grid empty: verify TableAdapter connection assignment and SP permissions.  
- For encrypted file garbage in editor: repo locked—run unlock.

## Build output

| Config | Path |
|--------|------|
| Debug | `ErcoView\bin\Debug\` |
| Release | `ErcoView\bin\Release\` |

`sql.env` should copy to output when the project item is configured (`CopyToOutputDirectory`).

## Installer project

`ErcoViewSetup` is a legacy VDPROJ. Modern VS versions may not build it. Prefer xcopy/MSI redesign for new packaging work.

## Quality bar for changes

- [ ] Training smoke test of touched workflow  
- [ ] No plaintext secrets added  
- [ ] `git-crypt status` clean for protected files  
- [ ] Permission levels considered (Admin/General/Super)  
- [ ] Docs updated if behavior/SP contract changed  

## Related

- [Contributing](contributing.md)  
- [Architecture](architecture.md)  
- [Task playbooks for agents](ai/task-playbooks.md)  
