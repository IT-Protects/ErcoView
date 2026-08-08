# Security

## Current posture (honest)

ErcoView is a legacy internal desktop app. Recent work improved secret storage in Git; **application and SQL auth still need hardening** for a modern threat model.

| Area | State |
|------|--------|
| Secrets in Git | **git-crypt** for `secrets/*.env` and `app.config` |
| SQL password in source | Removed from `modMain`; loaded from `sql.env` |
| App user passwords | Historically **plaintext** compare via `spLogin` |
| Authorization | Mostly **UI** permission flags |
| SQL access | Shared SQL login for all app users |
| Transport | Depends on SQL network config (encrypt/VPN) |

Detailed phased plan: [`EVALUATION-DEEP-DIVE.md`](../EVALUATION-DEEP-DIVE.md) §1.

## Secrets and git-crypt

**Always use git-crypt for secrets.**

| Do | Don't |
|----|--------|
| Put credentials in `secrets/*.env` | Hardcode passwords in `.vb` |
| Run `git-crypt status` before commit | Commit `*-git-crypt.key` |
| Share keys via vault/password manager | Paste keys or passwords into tickets/chat |
| Unlock on trusted workstations only | Email key files |

See [git-crypt.md](git-crypt.md).

### `secrets/sql.env` format

```env
SQL_USER=your_login
SQL_PASSWORD=your_password
```

Placeholders only in documentation—never real production values in markdown.

## Authentication flow

1. Client connects with shared SQL credentials.  
2. `spLogin(@userName)` returns user row (including password column historically).  
3. Client compares password strings.  
4. Sets `userPermission` and user id globals.

**Target state:** server-side hash verification; never return password material to the client.

## Authorization

| Level | Name | Client behavior (summary) |
|-------|------|---------------------------|
| 1 | Admin | Full UI |
| 2 | General | Restricted create/user admin |
| 3 | Superintendent | Restricted proposal create / folders / layouts |

Do not assume SQL denies unauthorized SP execution unless you have verified GRANTs.

## Data classification

| Data | Sensitivity | Notes |
|------|-------------|--------|
| SQL login password | Critical | git-crypt |
| App user passwords | Critical | Hash at rest (goal) |
| Customer/contact PII | High | Training copies need care |
| Proposal commercial terms | High | Live DB access control |
| GPS / site locations | Medium–High | |
| Layout XML | Low | |

## Secure development rules

1. No new secrets in plaintext source, samples, or tests committed unlocked.  
2. Prefer Windows Integrated Security for LAN when redesigning connections.  
3. Do not log passwords or full connection strings.  
4. When changing auth, update Training first and document SP contracts.  
5. After any accidental plaintext secret commit: rotate credential + consider history purge.

## Network

- Prefer VPN for Remote SQL.  
- Avoid exposing SQL ports to the public internet.  
- Enable SQL TLS where possible.

## Reporting security issues

If you find a vulnerability in this codebase:

1. Do not open a public issue with exploit details if the repo visibility could change.  
2. Notify repository maintainers / IT-Protects owners through private channels.  
3. Rotate affected credentials immediately if exposure is likely.

## Related

- [Operations](operations.md)  
- [Getting started](getting-started.md)  
- Evaluation deep dive security phases  
