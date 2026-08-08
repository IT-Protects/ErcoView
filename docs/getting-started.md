# Getting started

End-to-end path from zero to a running ErcoView against a Training database.

## Prerequisites

| Requirement | Notes |
|-------------|--------|
| Windows | WinForms desktop only |
| Git | With git-crypt available on `PATH` |
| git-crypt key | Team key file (never in the repo) |
| Visual Studio | VB.NET workload; able to target .NET Framework 4.0 |
| DevExpress 12.2 | DXperience 12.2 installed, or adjust project HintPaths to local DLLs |
| SQL Server access | `ErcoView_Training` (and optionally Live) with full SP set |
| Optional | Google Earth or other KML client for map export |

### git-crypt on Windows

If `git-crypt` is missing:

1. Place `git-crypt.exe` on your PATH (e.g. `%USERPROFILE%\.local\bin`).
2. Confirm: `git-crypt --version`

Details: [git-crypt.md](git-crypt.md).

## 1. Clone

```powershell
git clone https://github.com/IT-Protects/ErcoView.git
cd ErcoView
```

## 2. Unlock secrets

```powershell
git-crypt unlock path\to\ercoview-git-crypt.key
git-crypt status
```

You should be able to read plaintext:

- `secrets/sql.env` — `SQL_USER` / `SQL_PASSWORD`
- `ErcoView/app.config` — design-time connection defaults / hosts

Without unlock, the app cannot load SQL credentials.

## 3. Configure hosts (if needed)

After first run, or via **Settings** on the logon form:

| Setting | Purpose | User setting key |
|---------|---------|------------------|
| Internal SQL host | Local mode | `localIP` |
| External SQL host | Remote mode | `remoteIP` |
| Proposal folder | Browse / templates | `browseFolder` |
| Layout paths | Grid layouts | `layoutPathLocal`, `layoutPathServer` |

Defaults are stored in user settings / `app.config`. Prefer Training while learning.

## 4. Open and build

1. Open `ErcoView.sln` in Visual Studio.
2. Set startup project to **ErcoView**.
3. Build **Debug**.
4. Ensure `secrets\sql.env` is copied to the output directory (project item `CopyToOutputDirectory=PreserveNewest`).

**Common build blockers**

- Missing DevExpress 12.2 references (HintPaths under `C:\Program Files (x86)\DevExpress\...`)
- Missing .NET Framework 4.0 targeting pack
- git-crypt still locked → `app.config` unreadable garbage

## 5. First login

1. Run ErcoView.
2. Choose **Training** + **Local** (safest).
3. Enter a valid app user from the Training database.
4. Confirm title bar: `EV2 [version] [TRAINING DATABASE]`.

Permission levels affect which ribbon actions appear (see [Domain model](domain-model.md#permissions)).

## 6. Verify health

| Check | Expected |
|-------|----------|
| Logon succeeds | Main ribbon form opens |
| Proposal grid | Rows load via `spGetProposals` |
| Edit a proposal (Training) | Save calls `spUpdateProposal` |
| Settings → change password | Uses `spUpdatePassword` |
| Map (optional) | KML written beside EXE from template |

## 7. Day-two developer setup

```powershell
# Status
git status
git-crypt status

# Never commit the key
# Key example location (local machine only):
#   %USERPROFILE%\.config\ercoview\ercoview-git-crypt.key
```

Read next:

1. [Architecture](architecture.md)  
2. [Development](development.md)  
3. [AI context map](ai/context-map.md) if using coding agents  

## Minimal “I only need the EXE”

If binaries already exist under `ErcoView\bin\Release` or `bin\Debug`:

1. Still unlock git-crypt (or deploy a decrypted `sql.env` + config with the EXE).
2. Ensure `secrets\sql.env` is next to the EXE (or under a parent path the loader searches — see `TryLoadSqlCredentials` in `modMain.vb`).
3. Point Settings at a reachable SQL host.
4. Use Training until validated.

## Safety checklist

- [ ] Using **Training** unless intentionally on Live  
- [ ] git-crypt unlocked only on trusted machines  
- [ ] Key not copied into the repo or chat logs  
- [ ] No new plaintext passwords in source  
