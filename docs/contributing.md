# Contributing

Thanks for helping maintain ErcoView.

## Ground rules

1. **Secrets:** always git-crypt; never commit keys or plaintext credentials.  
2. **Training first:** validate on `ErcoView_Training`.  
3. **Small, reviewable PRs:** especially avoid noisy Designer-only churn unless required.  
4. **Document behavior changes** in `docs/` when user-visible or SP contracts change.  
5. **MIT license** — by contributing you agree your changes are under the repo license.

## Workflow

```text
fork/branch → git-crypt unlock → code → Training test → PR → review → merge
```

### PR checklist

- [ ] Purpose stated (bugfix / feature / docs / chore)  
- [ ] Training test notes  
- [ ] Screenshots if UI changed  
- [ ] `git-crypt status` OK  
- [ ] Docs updated if needed  
- [ ] No secrets in plaintext  

## Code review focus

- SQL injection risk (should use SPs + parameters)  
- Permission gating for new actions  
- Connection disposal / `Using`  
- Compatibility with DevExpress 12.2 and .NET 4.0  
- Whether secrets belong under encrypted paths  

## Communication

- Prefer issues/PRs on GitHub for technical discussion.  
- Security-sensitive reports: private channel to maintainers (see [security.md](security.md)).

## Docs contributions

Documentation lives under `docs/`. Keep the [docs index](README.md) links accurate. AI-oriented pages under `docs/ai/` should stay machine-actionable (paths, checklists, do/don't).
