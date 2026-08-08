# Operations

## Deployment artifacts

| Artifact | Location | Notes |
|----------|----------|--------|
| Application | `ErcoView\bin\Release\ErcoView.exe` (after build) | Needs DevExpress DLLs beside it |
| Config | `ErcoView.exe.config` | Generated from `app.config` |
| Secrets | `secrets\sql.env` | Must be present for SQL auth path |
| KML template | `ErcoViewTemplate.kml` | Copied to output |
| Installer | `ErcoViewSetup` (.vdproj) | Legacy; may need older VS |

## Deploy checklist

1. Build Release on a machine with DevExpress 12.2.  
2. Unlock git-crypt on the build agent **or** inject decrypted `sql.env` / config via secure pipeline.  
3. Package EXE + DevExpress deps + `ErcoViewTemplate.kml` + `secrets\sql.env`.  
4. Ensure clients can reach the intended SQL host (Local/Remote).  
5. Verify layout UNC paths and proposal browse folders exist and are ACL’d.  
6. Smoke test: Training logon → open proposal → open one report.  
7. Only then point users at Live.

## Live vs Training

| | Training | Live |
|--|----------|------|
| Purpose | Practice / test | Production |
| Catalog | `ErcoView_Training` | `ErcoView_Live` |
| UI cue | Title bar TRAINING | Title bar LIVE |
| Policy | Default for experiments | Change-controlled |

Operators should treat Live writes as production data changes.

## Local vs Remote

| | Local | Remote |
|--|-------|--------|
| Host setting | `localIP` | `remoteIP` |
| Typical network | LAN / VPN internal | External host |

Wrong host is the most common “cannot login / connection failed” cause after credential issues.

## User settings (per Windows user)

Persisted via `My.Settings` (see [reference/settings.md](reference/settings.md)):

- Last logon name  
- Live/Remote combo indices  
- Layout paths, browse folder  
- SQL host strings  

Roaming/profile issues can “lose” settings; document expected defaults for helpdesk.

## Layouts

| Path | Role |
|------|------|
| `layoutPathLocal` | Preferred if file exists |
| `layoutPathServer\Admin\|General\|Super` | Fallback by `userPermission` |

Ensure server share permissions match role folders.

## Proposal documents

Browse root (`browseFolder` / related UNC) holds proposal folders and templates (e.g. `1-New Template`). File server outages break browse/copy features but not necessarily grid load.

## Monitoring and support

| Signal | Where |
|--------|-------|
| User-facing errors | `MsgBox` with exception message |
| App log config | `app.config` FileLog listener (basic) |
| SQL | Server-side logs / Profiler / Extended Events |

For production support, capture: Live/Training, Local/Remote, username (not password), exact error text, time, and proposal id if relevant.

## Backup

- SQL: standard DB backup of Live (and Training if valuable).  
- Layouts: backup layout share.  
- Secrets: backup git-crypt key in vault (not on the same backup as public clones only).  

## Versioning

Assembly version `20.9.28` (see `AssemblyInfo.vb`). On upgrade, app may show a version MsgBox and set `evVersion` user setting.

## Related

- [Troubleshooting](troubleshooting.md)  
- [Security](security.md)  
