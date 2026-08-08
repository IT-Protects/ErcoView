# ErcoView

ErcoView project management tool for **Er-Con Technologies** (IMAGE CES / EV2).

Legacy **VB.NET WinForms** desktop app for proposals, customers, vendors, contacts, job numbers, and DevExpress reports.

| Item | Value |
|------|--------|
| Language | Visual Basic .NET |
| Framework | .NET Framework 4.0 |
| UI | WinForms + DevExpress 12.2 |
| Data | SQL Server (`ErcoView_Live` / `ErcoView_Training`) via stored procedures |
| Version | 20.9.28 |
| License | MIT (see [LICENSE](LICENSE)) |

## Solution layout

```
ErcoView.sln
├── ErcoView/           Main WinExe
└── ErcoViewSetup/      Legacy Visual Studio setup project (.vdproj)
```

## Requirements to build

- Visual Studio with VB.NET / .NET Framework 4.0 targeting pack
- **DevExpress DXperience 12.2** (project HintPaths point at the install folder)
- SQL Server with ErcoView databases and stored procedures
- Windows (WinForms)

## Security note

SQL credentials live in **git-crypt**–encrypted `secrets/sql.env` (not hardcoded in source). See [docs/git-crypt.md](docs/git-crypt.md) for unlock steps.

Treat the repository as **private**. Old git history may still contain prior plaintext secrets — rotate credentials that were ever committed. Prefer Windows Integrated Security long term.

See `EVALUATION-DEEP-DIVE.md` for a security plan, DB dependency map, bug notes, and modernization roadmap.

## Status

Evaluation and small bug fixes (logon Local/Remote selection; multi-customer ID mapping) are documented in-repo. Full schema/SP definitions live on SQL Server, not in this tree.
