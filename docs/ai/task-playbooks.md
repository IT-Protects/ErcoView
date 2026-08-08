# AI task playbooks

Step-by-step recipes. Execute in order; stop if secrets would leak.

---

## Playbook: Fix a bug in proposal save

1. Read `docs/ai/context-map.md` row for proposals.  
2. Open `Class/clsFrmProposal.vb` — find `UpdateProposal` / `Insert` / `SetValues`.  
3. Confirm SP name and parameters match intent.  
4. If Utils mapping involved, check `Utils.vb` for off-by-slot bugs.  
5. Patch handler; avoid Designer unless UI required.  
6. Manual test plan: Training → edit proposal → save → reopen.  
7. Update docs if behavior changed.

---

## Playbook: Add a field to proposal UI

1. Confirm column exists in `spGetProposals` / update SP on Training.  
2. Refresh or edit DataSet if TableAdapter shape changes.  
3. Add control on `frmProposal` (Designer).  
4. Wire load/save in `clsFrmProposal` (`SetValues` + update/insert params).  
5. Training test create + edit paths.  
6. Document field in `docs/domain-model.md` if user-facing.

---

## Playbook: Add or change a secret

1. Unlock git-crypt.  
2. Put value in `secrets/*.env` or approved encrypted path.  
3. Ensure `.gitattributes` encrypts that path.  
4. `git add` file; confirm blob starts with `GITCRYPT` via `git show :path`.  
5. Load secret in code without logging it.  
6. Never commit export-key output.

---

## Playbook: Change SQL connection behavior

1. Read `modMain.GetConnectionString` and `TryLoadSqlCredentials`.  
2. Keep Training/Live and Local/Remote matrix intact unless replacing deliberately.  
3. Do not re-hardcode passwords.  
4. Test all four combos if host logic changes (or document which you tested).  
5. Update `docs/database.md` + `docs/troubleshooting.md`.

---

## Playbook: New report

1. Define/verify SP on Training with stable result shape.  
2. Add TableAdapter to `dsErcoView` **or** fill manually.  
3. Create `Forms/Reports/rptX` DevExpress report.  
4. Add setup UI if parameters needed.  
5. Wire from `clsFrmMain` / reports menu.  
6. Assign connection before Fill.  
7. Document in forms + SP reference.

---

## Playbook: Permission-aware feature

1. Identify whether Admin/General/Super should access it.  
2. Gate in `modMain` and/or handler open path.  
3. Note lack of server-side enforcement in PR.  
4. Test with each permission if feasible.

---

## Playbook: Safe documentation-only change

1. Edit `docs/**`, `README.md`, `AGENTS.md`, `llms.txt` as needed.  
2. Keep secret examples as placeholders.  
3. Fix index links in `docs/README.md`.  
4. No need to unlock git-crypt unless touching encrypted files.

---

## Playbook: Review a PR as an agent

1. Scan for passwords, tokens, key files.  
2. Check `.gitattributes` coverage for new secret paths.  
3. Prefer handler changes over unexplained Designer noise.  
4. Ensure SP calls parameterized.  
5. Ensure Training test notes exist.  
6. Verify docs updated for contract changes.

---

## Stop conditions (do not proceed)

- User asks to commit git-crypt **key**  
- Change requires Live data destruction without explicit approval  
- Introducing plaintext production credentials  
- Generating exploit code against production SQL  
