# AI documentation

This folder optimizes for **coding agents and LLMs** working on ErcoView. Humans are welcome; start at [docs/README.md](../README.md) for narrative guides.

## Mandatory reads (in order)

1. **[`AGENTS.md`](../../AGENTS.md)** (repo root) — hard rules (git-crypt, safety)  
2. **[context-map.md](context-map.md)** — which files to open for a task  
3. **[coding-conventions.md](coding-conventions.md)** — how to edit without breaking style  
4. **[task-playbooks.md](task-playbooks.md)** — step recipes  

Then load the human doc that matches the domain (architecture, database, security).

## Machine index

Root [`llms.txt`](../../llms.txt) lists canonical doc URLs/paths for crawlers and agents.

## Operating constraints agents must respect

| Constraint | Detail |
|------------|--------|
| Stack | VB.NET, .NET FX 4.0, WinForms, DevExpress 12.2 |
| Data | Stored procedures only for mutations; no ad-hoc SQL concatenation |
| Secrets | git-crypt only; never print `sql.env` values into chat/commits |
| DB truth | SP bodies may be absent; do not invent table schemas without evidence |
| Env | Prefer Training catalog for all experiments |
| Tests | No automated suite—manual Training smoke is the bar |

## Suggested agent prompt preamble

```text
You are working in the ErcoView monorepo (VB.NET WinForms).
Follow AGENTS.md and docs/ai/* .
Use git-crypt for secrets. Do not commit keys.
Prefer changing Class/clsFrm*.vb over fat Designer files.
Validate mental model against docs/database.md and docs/reference/* .
Use Training DB assumptions; never require Live.
```

## Confidence levels when answering

| Claim type | Source |
|------------|--------|
| File paths, handlers | Repo tree |
| SP names | Client call sites + XSD |
| Table columns | XSD result shapes only unless DB export exists |
| Business process intent | Domain docs + form labels; mark uncertainty |
| Production hostnames | Treat as sensitive; prefer placeholders in answers |
