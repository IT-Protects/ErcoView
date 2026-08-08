# Troubleshooting

## Quick matrix

| Symptom | Likely cause | What to try |
|---------|--------------|-------------|
| Logon: connection error | Wrong host, SQL down, firewall, bad `sql.env` | Settings hosts; `sql.env`; VPN; SQL connectivity test |
| Logon: invalid user | User missing in catalog | Confirm Training vs Live; check Users table/SP |
| Logon: incorrect password | Wrong password or SP column mismatch | Reset via admin; verify `spLogin` contract |
| “SQL credentials not found” | Missing/unlocked `sql.env` | `git-crypt unlock`; ensure file beside EXE or search path |
| Editor shows binary garbage in `app.config` | git-crypt locked | `git-crypt unlock <key>` |
| Build: DevExpress missing | Not installed / bad HintPath | Install DX 12.2 or retarget references |
| Empty grids | Connection not set / SP fail / permissions | Assign `GetConnectionString()`; check SQL errors |
| Cannot see Users page | Not Admin | `userPermission` must be 1 |
| Cannot create proposal | Super (3) | Expected restriction |
| Map does nothing useful | No selection / no GPS / no template | Select rows; GPS fields; `ErcoViewTemplate.kml` present |
| Layout not found | Path/ACL | Check local path then server role folder |
| Training looks like Live data | Misconfigured catalog or shared DB | Verify title bar; verify `isDatabaseLive` |

## Connection string path

1. Confirm login combos: Training/Live, Local/Remote.  
2. Read `secrets/sql.env` (unlocked).  
3. Confirm `localIP` / `remoteIP` in Settings.  
4. Test from SSMS with same host/catalog/user.  
5. Breakpoint `GetConnectionString()` / `TryLoadSqlCredentials`.

## git-crypt issues

```powershell
git-crypt status
git check-attr filter secrets/sql.env ErcoView/app.config
```

| Problem | Fix |
|---------|-----|
| Command not found | Install `git-crypt.exe` on PATH |
| Unlock fails | Wrong key; get key from vault |
| Files still encrypted after unlock | Wrong repo / partial clone; re-unlock |
| Accidentally committed key | Rotate: new `git-crypt` key strategy + remove key from history; treat secrets as burned |

## Auth issues after password hashing work

If someone partially implements hashing:

- Client still comparing plaintext will break all logins.  
- Coordinate SP + client cutover; test on Training only.

## Report failures

1. Same connection assignment as grids.  
2. Year/month parameters required by SP.  
3. DevExpress report designer version mismatch.

## Performance

- Main grid SP returning too many columns/rows.  
- `Utils.GetTextStringFromIDs` multi-round-trip pattern.  
- Remote SQL over high latency without VPN quality.

## Capturing a good bug report

Include:

- ErcoView version (title bar)  
- Live vs Training, Local vs Remote  
- Windows user (optional), **app username** (not password)  
- Exact message text  
- Repro steps  
- Whether git-crypt was unlocked (for config issues)  

## Related

- [Getting started](getting-started.md)  
- [Operations](operations.md)  
- [Security](security.md)  
