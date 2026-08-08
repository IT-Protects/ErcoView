# Reference: settings and configuration

## Runtime secrets (git-crypt)

| File | Keys | Consumer |
|------|------|----------|
| `secrets/sql.env` | `SQL_USER`, `SQL_PASSWORD` | `modMain.TryLoadSqlCredentials` |

## `My.Settings` (user-scoped)

From `app.config` / `Settings.settings` (names as used in code):

| Setting | Purpose |
|---------|---------|
| `logonName` | Last username |
| `Live` | Database combo index (Training/Live) |
| `Remote` | Location combo index (Local/Remote) |
| `localIP` | SQL host for Local |
| `remoteIP` | SQL host for Remote |
| `layoutPathLocal` | Local layouts directory |
| `layoutPathServer` | Server layouts root |
| `browseFolder` | Proposal documents root |
| `erconBrowseFolder` | Alternate/UNC browse root |
| `layoutCustomer` / `layoutContact` / `layoutVendor` / `layoutUser` / `layoutProposal` | Last layout names |
| `callUpgrade` | Migrate settings once |
| `evVersion` | Last seen app version string |
| `bookingMonth` / `bookingYear` / `reportYear` | Report UI memory |

Exact defaults can change; inspect unlocked `ErcoView/app.config` after `git-crypt unlock`.

## Design-time connection strings

`app.config` may contain many `connectionStrings` entries used by DataSet designers (often Integrated Security + historical servers). **Runtime data access for business operations uses `GetConnectionString()`**, not those entries, once handlers reassign TableAdapter connections.

## Assembly version

`My Project/AssemblyInfo.vb` — e.g. `20.9.28`.

## Environment variables

Not required by default. Future hardening may add env-based secret injection; today prefer git-crypt files.
