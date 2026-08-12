# Improvement roadmap

How we improve **ErcoView** and keep **[IT-Protects/ErcoView](https://github.com/IT-Protects/ErcoView)** current.

Related: [`EVALUATION-DEEP-DIVE.md`](../EVALUATION-DEEP-DIVE.md) (detailed security/DB/modernization analysis).

---

## Baseline (done)

- [x] Private GitHub repo with source
- [x] git-crypt for `secrets/sql.env` and `app.config`
- [x] Hardcoded SQL password removed from application source
- [x] Logon Local/Remote selection fix
- [x] Multi-customer ID slot fix
- [x] Human + AI documentation suite
- [x] GitHub PR / issue templates
- [x] `db/` folder scaffold for schema/SP exports

---

## Track A — Stabilize & secure (P0)

| ID | Item | Status |
|----|------|--------|
| A1 | Rotate SQL password; vault + git-crypt only; network check | **Ops — do ASAP** |
| A2 | Hash app passwords; server-side verify; stop returning password from login | Planned — [design](design/auth-password-hashing.md) |
| A3 | Enforce permissions on write SPs (`@actingUserId`) | Planned |
| A4 | Document / optional history scrub for pre-git-crypt secrets | Planned |

## Track B — Product quality (P1)

| ID | Item | Status |
|----|------|--------|
| B1 | Utils null handling, N+1, connection hygiene, dead insert path | Planned |
| B2 | Collapse dead/duplicate connection strings | Planned |
| B3 | Central file logging | Planned |
| B4 | Export Training schema/SPs into `db/` | **Waiting on SQL access** |
| B5 | Build doc + optional docs CI | Planned |
| B6 | Branch protection, releases, CODEOWNERS | Planned (GitHub settings) |

## Track C — Modernization (P2)

| Path | When | First step |
|------|------|------------|
| **C-M** In-place (.NET 4.8, cleaner structure, installer) | Default if desktop stays | Retarget 4.8 after Track A |
| **C-R** Rewrite (API + web/desktop client) | Web/multi-site required | Read-only proposals API spike |

Do **not** start C until A1–A2 are done (or explicitly waived).

---

## Sprint-style sequence

```text
Sprint 0    A1 rotate + network; templates ✅; start db export
Sprint 1–2  A2 password hashing (Training → Live)
Sprint 2–3  A3 SP authz; B1/B2 fixes
Sprint 3–4  B3 logging; B4 complete; B5 build docs
Sprint 5+   C-M or C-R decision
```

## How we update the repo

1. Branch from `main` (`security/…`, `fix/…`, `docs/…`, `db/…`).
2. Unlock git-crypt when touching secrets/config.
3. Test on **Training**.
4. Open PR with the [PR template](../.github/PULL_REQUEST_TEMPLATE.md).
5. Merge; tag releases when shipping user-visible builds.
6. Keep `docs/reference/*` aligned with SP/UI changes.

## Success metrics

| Metric | Target |
|--------|--------|
| Plaintext secrets in new commits | 0 |
| Users with hashed passwords | 100% post-migration |
| SP scripts in `db/` vs client inventory | ≥ 95% |
| Critical security issues open | 0 untriaged |
