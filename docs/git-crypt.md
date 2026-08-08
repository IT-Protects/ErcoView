# git-crypt on ErcoView

This repository uses **git-crypt** so credentials and sensitive config are encrypted in Git.

## What is encrypted

Configured in `.gitattributes`:

| Path | Why |
|------|-----|
| `secrets/*.env`, `secrets/**/*.env` | SQL and other runtime secrets |
| `**/*.secret`, `**/.env*` | Generic secret files |
| `ErcoView/app.config` | Connection strings / host defaults |

`secrets/README.md` and this file stay **plaintext**.

## Unlock (after clone)

1. Get the team key file from a secure channel (password manager / org vault). **Never commit the key.**
2. Install `git-crypt` (Windows: place `git-crypt.exe` on `PATH`, e.g. `%USERPROFILE%\.local\bin`).
3. From the repo root:

```powershell
git-crypt unlock path\to\ercoview-git-crypt.key
git-crypt status
```

## Export key (maintainers)

```powershell
git-crypt export-key path\to\secure\ercoview-git-crypt.key
```

## SQL credentials

Edit `secrets/sql.env` (after unlock):

```
SQL_USER=...
SQL_PASSWORD=...
```

Loaded by `GetConnectionString()` in `modMain.vb`.

## Agent rule

Always use git-crypt when adding or changing secrets. See `AGENTS.md` and global Grok rule `git-crypt`.
