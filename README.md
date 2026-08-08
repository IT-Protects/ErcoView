# ErcoView

Legacy **VB.NET WinForms** desktop app (IMAGE CES / EV2) for proposals, customers, vendors, contacts, job numbers, and DevExpress reports.

| Item | Value |
|------|--------|
| Language | Visual Basic .NET |
| Framework | .NET Framework 4.0 |
| UI | WinForms + DevExpress 12.2 |
| Data | SQL Server (`ErcoView_Live` / `ErcoView_Training`) via stored procedures |
| Version | 20.9.28 |

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

This codebase historically embedded SQL credentials and used plaintext application passwords. Treat the repository as **private**. Rotate any credentials that may have been committed, and prefer Windows Integrated Security or secrets outside source control.

See `EVALUATION-DEEP-DIVE.md` for a security plan, DB dependency map, bug notes, and modernization roadmap.

## Status

Evaluation and small bug fixes (logon Local/Remote selection; multi-customer ID mapping) are documented in-repo. Full schema/SP definitions live on SQL Server, not in this tree.
