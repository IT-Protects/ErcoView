# Design: application password hashing

**Status:** Proposed  
**Track:** A2 (security)  
**Environments:** Implement and validate on **Training** first; promote to Live under change control.

## Problem

Today (legacy behavior):

1. Client connects with a shared SQL login (`secrets/sql.env`).
2. `spLogin(@userName)` returns a row that includes a **password** field.
3. `clsLogon` compares the typed password to that value in process memory.
4. User admin UI and grids can expose password material via `spGetUsers`.

This fails modern baseline security (offline hash cracking, grid leakage, client-side verify).

## Goals

- Passwords stored only as **salted hashes** (PBKDF2 or equivalent available on .NET 4.0).
- Login verification happens **in SQL or in app against hash only**—never return reversible password.
- Existing users migrate without mass manual re-entry if possible (one-time hash of current plaintext, then force change optional).
- Training cutover reversible until Live promotion.

## Non-goals

- Replacing shared SQL login (separate track; Integrated Security preferred long-term).
- Full claims-based / Entra ID (Track C rewrite).
- Changing permission IDs 1/2/3 semantics.

## Proposed data model

Prefer additive columns on the users table (names illustrative—confirm real table name on export):

| Column | Type | Notes |
|--------|------|--------|
| `PASSWORD_HASH` | `varbinary` or `nvarchar` | PBKDF2 output (include iterations in format) |
| `PASSWORD_SALT` | `varbinary` | Per-user salt (or encode salt into hash string) |
| `PASSWORD` | legacy | Nullable after migration; drop later |

**Recommended hash format (app-side compute, store string):**

```text
PBKDF2$<iterations>$<base64-salt>$<base64-hash>
```

Iterations: ≥ 100_000 (tune for desktop UX).

Alternatively: hash only inside SP using SQL crypto—if org forbids app-side crypto, document SP-only design; app still must not receive plaintext password back.

## Procedure contracts

### `spAuthenticate` (new) or revised `spLogin`

**Input**

| Param | Type |
|-------|------|
| `@userName` | nvarchar |
| `@password` | nvarchar (plain, over TLS/VPN to SQL—minimize logging) |

**Output (result set, no secret columns)**

| Column | Meaning |
|--------|---------|
| `USER_ID` | int |
| `FIRST_NAME`, `LAST_NAME` | display |
| `USER_NAME` | login |
| `EMAIL` | optional |
| `PERMISSION` / `PERMISSION_ID` | role |
| `SALESMAN`, `SUPER`, `ACTIVE` | flags |

**Behavior**

1. Lookup user by name where active.
2. Verify password against hash (or legacy plaintext during dual-read window).
3. On success return profile row **without** password/hash.
4. On failure return empty set (same for unknown user—avoid user enumeration if possible).

### `spUpdatePassword` / user insert-update

- Accept plain password **once**, hash in app **or** SP before write.
- Never SELECT hash into UI grids.

### `spGetUsers`

- Remove `PASSWORD` from result set used by TableAdapter/UI.

## Client changes

| File | Change |
|------|--------|
| `clsLogon.vb` | Call authenticate SP with user+password; map profile; remove local string compare |
| `clsFrmUsers.vb` | On save, send password only when changed; do not display stored secret |
| `frmSettings.vb` | Change password → hash path |
| `dsErcoView` / user form | Drop password column bind from grid if present |
| New helper | `PasswordHasher.vb` (PBKDF2) if hashing in app |

## Migration plan

1. Deploy columns + new/changed SPs on **Training**.  
2. Dual-read period: if hash null, verify against legacy `PASSWORD` and upgrade hash on successful login.  
3. Batch job: hash all remaining legacy passwords.  
4. Disable legacy plaintext verify.  
5. Null out legacy `PASSWORD` column.  
6. Repeat on Live; communicate forced re-login.  
7. Drop legacy column in a later release.

## Rollback

- Keep dual-read until Live stable.  
- Re-enable legacy verify only on Training if needed; never re-commit plaintext to git.

## Test plan (Training)

| Case | Expected |
|------|----------|
| Correct password | Login, main form, correct permission |
| Wrong password | Failure message, no partial session |
| Inactive user | Failure |
| Password change | Old fails, new works |
| User grid | No password column visible |
| New user create | Can log on with set password |

## Security notes

- Still using shared SQL login for app data—A3/A1 remain relevant.  
- Prefer VPN + SQL encryption for Remote.  
- Do not log `@password` parameters.  
- git-crypt remains required for `sql.env`.

## Implementation order

1. Export user-related SP/table scripts into `db/` (B4).  
2. Land schema + SP on Training.  
3. Client PR + Training UAT.  
4. Live promotion checklist signed by owner.
