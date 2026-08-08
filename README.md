# ErcoView

**ErcoView** (EV2) is the project management / proposal CRM desktop application for **Er-Con Technologies** (IMAGE CES lineage).

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

| | |
|--|--|
| **Stack** | VB.NET · .NET Framework 4.0 · WinForms · DevExpress 12.2 |
| **Data** | SQL Server (`ErcoView_Live` / `ErcoView_Training`) via stored procedures |
| **Version** | 20.9.28 |
| **Repo** | [IT-Protects/ErcoView](https://github.com/IT-Protects/ErcoView) |

---

## Documentation

**World-class docs for humans and AI live in [`docs/`](docs/README.md).**

| Audience | Start here |
|----------|------------|
| **Everyone** | [Documentation hub](docs/README.md) |
| **New developers** | [Getting started](docs/getting-started.md) |
| **Operators** | [Operations](docs/operations.md) · [Troubleshooting](docs/troubleshooting.md) |
| **Security** | [Security](docs/security.md) · [git-crypt](docs/git-crypt.md) |
| **AI agents** | [`AGENTS.md`](AGENTS.md) · [AI docs](docs/ai/README.md) · [`llms.txt`](llms.txt) |
| **Deep dive** | [Evaluation & roadmap](EVALUATION-DEEP-DIVE.md) |

---

## Quick start

```powershell
git clone https://github.com/IT-Protects/ErcoView.git
cd ErcoView
git-crypt unlock path\to\ercoview-git-crypt.key   # required for secrets
# Open ErcoView.sln in Visual Studio → Build → run against Training
```

Full prerequisites and first-login steps: [docs/getting-started.md](docs/getting-started.md).

---

## Solution layout

```text
ErcoView.sln
├── ErcoView/           Main WinExe (Forms, Class handlers, DataSets)
├── ErcoViewSetup/      Legacy Visual Studio setup project (.vdproj)
├── secrets/            git-crypt–encrypted credentials (see docs)
└── docs/               Human + AI documentation
```

---

## Architecture at a glance

```text
User → WinForms/DevExpress → Class/clsFrm* handlers → SQL stored procedures
                              modMain (globals, connection, startup)
                              secrets/sql.env (SQL auth via git-crypt)
```

Details: [docs/architecture.md](docs/architecture.md).

---

## Security

- SQL credentials are **not** hardcoded; they load from **`secrets/sql.env`** (git-crypt).  
- **Always use git-crypt** for secrets (see [`AGENTS.md`](AGENTS.md)).  
- Treat the repository as **private**. Rotate any credentials that appeared in older git history.  
- App user passwords are historically plaintext in the database path—hardening plan in the evaluation doc.

---

## Requirements to build

- Windows + Visual Studio (VB.NET / .NET Framework 4.0 targeting pack)  
- **DevExpress DXperience 12.2** (project HintPaths reference the install tree)  
- SQL Server with ErcoView catalogs and stored procedures  
- `git-crypt` unlock for `app.config` and `secrets/sql.env`  

---

## Contributing

See [docs/contributing.md](docs/contributing.md) and [docs/development.md](docs/development.md).

## License

[MIT](LICENSE) © IT Protects / project contributors.
