# ErcoView documentation

**Audience:** humans (operators, developers, maintainers) and AI coding agents.  
**Product:** ErcoView (EV2) — proposal and project CRM for **Er-Con Technologies** (IMAGE CES).  
**Repo:** [IT-Protects/ErcoView](https://github.com/IT-Protects/ErcoView)

---

## Start here

| You want to… | Read |
|--------------|------|
| Understand what the app is | [Overview](overview.md) |
| Clone, unlock secrets, run | [Getting started](getting-started.md) |
| See how the system is built | [Architecture](architecture.md) |
| Learn business entities | [Domain model](domain-model.md) |
| Work with SQL / SPs | [Database](database.md) · [`db/`](../db/README.md) |
| Operate in production | [Operations](operations.md) |
| Change code safely | [Development](development.md) |
| Handle credentials | [Security](security.md) · [git-crypt](git-crypt.md) |
| Fix common failures | [Troubleshooting](troubleshooting.md) |
| Look up screens / SPs / settings | [Reference](reference/README.md) |
| See improvement plan | [Roadmap](roadmap.md) |
| Onboard an AI agent | [AI documentation](ai/README.md) · root [`AGENTS.md`](../AGENTS.md) |

Deep evaluation (risks, modernization): [`EVALUATION-DEEP-DIVE.md`](../EVALUATION-DEEP-DIVE.md)  
Auth hashing design: [`design/auth-password-hashing.md`](design/auth-password-hashing.md)

---

## Documentation map

```text
docs/
├── README.md                 ← you are here
├── overview.md               Product purpose & scope
├── getting-started.md        Clone → unlock → build → first login
├── architecture.md           Layers, runtime flow, patterns
├── domain-model.md           Proposals, parties, permissions
├── database.md               Catalogs, SPs, connection model
├── ui-and-workflows.md       Screens and primary user journeys
├── security.md               Threats, secrets, permissions
├── operations.md             Deploy, settings, Live vs Training
├── development.md            Build, conventions, PR checklist
├── troubleshooting.md        Symptoms → causes → fixes
├── glossary.md               Terms
├── git-crypt.md              Secret encryption
├── contributing.md           How to contribute
├── roadmap.md                Improvement plan & status
├── design/                   Design notes (e.g. password hashing)
├── reference/
│   ├── README.md
│   ├── forms-and-handlers.md
│   ├── stored-procedures.md
│   └── settings.md
└── ai/
    ├── README.md             Agent entrypoint
    ├── context-map.md        Where to read code for a task
    ├── coding-conventions.md Machine-actionable rules
    └── task-playbooks.md     Step recipes for common tasks
```

Root files for machines and humans:

| File | Role |
|------|------|
| [`README.md`](../README.md) | Project landing |
| [`AGENTS.md`](../AGENTS.md) | Mandatory agent rules (always loaded in-repo) |
| [`llms.txt`](../llms.txt) | LLM discovery index |
| [`LICENSE`](../LICENSE) | MIT |

---

## Principles of this doc set

1. **Truth over aspiration** — describe the code as it is (VB.NET 4.0, DevExpress 12.2, SP-centric).
2. **Dual audience** — prose for people; tables, paths, and checklists for agents.
3. **Secrets never in plaintext docs** — credentials only via git-crypt; examples use placeholders.
4. **Single source of navigation** — this index is the hub; avoid orphan pages.
5. **History is imperfect** — git history may contain pre-git-crypt secrets; treat as compromised until rotated.

---

## Version snapshot

| Item | Value |
|------|--------|
| App assembly version | 20.9.28 |
| Target framework | .NET Framework 4.0 |
| UI stack | WinForms + DevExpress 12.2 |
| Data access | SQL Server stored procedures + typed DataSet |
| License | MIT |
