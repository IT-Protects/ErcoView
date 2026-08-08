# ErcoView — agent instructions

These rules apply to **every** AI coding agent session in this repository.

## Identity

- **Product:** ErcoView (EV2) — WinForms proposal/CRM for Er-Con Technologies  
- **Stack:** VB.NET · .NET Framework 4.0 · DevExpress 12.2 · SQL Server stored procedures  
- **Repo:** https://github.com/IT-Protects/ErcoView  

## Read first

| Priority | Resource |
|----------|----------|
| 1 | This file |
| 2 | [`docs/ai/README.md`](docs/ai/README.md) |
| 3 | [`docs/ai/context-map.md`](docs/ai/context-map.md) |
| 4 | Task-specific human doc under [`docs/`](docs/README.md) |
| 5 | [`llms.txt`](llms.txt) for full doc index |

## Hard rules

### Secrets (non-negotiable)

- **Always use git-crypt** for secrets and sensitive config.  
- Encrypted paths are defined in [`.gitattributes`](.gitattributes).  
- Put credentials in `secrets/*.env` (or another encrypted pattern)—**never** hardcode into `.vb`.  
- **Never** commit git-crypt key files (`*.key`, export-key output).  
- **Never** paste live passwords, keys, or full production connection strings into commits, docs, or PR text.  
- Before commit of secret files: verify encryption (`git show :path` should not be plaintext; expect `GITCRYPT` header).  
- Old git history may still contain prior plaintext secrets—do not reintroduce them; recommend rotation when relevant.

### Database safety

- Default all exploratory work to **Training** (`ErcoView_Training`).  
- Do not run destructive Live operations unless the user explicitly requests Live.  
- Do not invent table schemas; use XSD result shapes and client SP parameter lists. Prefer asking for SP definitions if needed.

### Code change discipline

- Prefer **`Class/clsFrm*.vb`** for behavior; keep forms thin.  
- Use **stored procedures + parameters** only for SQL.  
- Avoid wholesale rewrites of `*.Designer.vb` and `dsErcoView.Designer.vb`.  
- Match existing naming (`frm`, `clsFrm`, `sp…`).  
- Preserve intentional legacy column name typos unless a coordinated DB migration is in scope.  
- Update docs when you change SP contracts, workflows, or security behavior.

### Product constraints

- Stay on **.NET 4.0 / DevExpress 12.2** unless the task is an explicit modernization.  
- No new dependency that cannot work in this stack without approval.  
- There is **no automated test suite**—provide a manual Training test plan in the PR/summary.

## Architecture cheatsheet

```text
modMain.Main → clsLogon → clsFrmMain
Forms raise events; Class/ handlers call SPs
GetConnectionString() builds host+catalog; secrets/sql.env supplies SQL auth
userPermission: 1=Admin, 2=General, 3=Superintendent (UI gating)
```

## Common commands

```powershell
git-crypt unlock path\to\ercoview-git-crypt.key
git-crypt status
git check-attr filter secrets/sql.env ErcoView/app.config
```

## When unsure

1. Open [`docs/ai/task-playbooks.md`](docs/ai/task-playbooks.md).  
2. Open [`docs/troubleshooting.md`](docs/troubleshooting.md).  
3. State assumptions; prefer smallest safe change.  

## Doc map (short)

- Humans: [`docs/README.md`](docs/README.md)  
- Evaluation / roadmap: [`EVALUATION-DEEP-DIVE.md`](EVALUATION-DEEP-DIVE.md)  
- AI playbooks: [`docs/ai/`](docs/ai/README.md)  
