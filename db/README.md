# Database scripts

SQL Server is a **first-class part of ErcoView**. Application code expects catalogs and stored procedures that historically lived only on the server.

This folder is the home for **schema and procedure scripts** so humans and AI agents can reason about the backend offline.

## Status

| Area | Status |
|------|--------|
| Client SP inventory | Documented in [`docs/reference/stored-procedures.md`](../docs/reference/stored-procedures.md) |
| Scripts in this folder | **Populate from Training** using the export process below |
| Production data | **Never commit** dumps with PII or passwords |

```text
db/
├── README.md           ← you are here
├── NOTES.md            ← Live vs Training drift, conventions
├── schema/             ← tables, views, types (no data)
└── procedures/         ← stored procedure definitions
```

Until exports land, treat the **running Training database** as source of truth.

## Export from SSMS (Training first)

1. Connect to the Training instance and database `ErcoView_Training`.
2. Right-click database → **Tasks** → **Generate Scripts…**
3. Choose objects:
   - Tables (schema only)
   - Stored procedures
   - Views / functions if present
4. Advanced options:
   - **Types of data to script:** Schema only  
   - Script indexes / FKs: True  
   - Do **not** script logins with passwords  
5. Save to files, then place under:

```text
db/schema/          -- tables, views
db/procedures/      -- one file per SP recommended (or batched by area)
```

6. Open a PR. Redact any accidental secrets before commit.

### Optional T-SQL inventory (no bodies)

```sql
SELECT ROUTINE_SCHEMA, ROUTINE_NAME
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE'
ORDER BY 1, 2;

SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY 1, 2;
```

## Restore order (greenfield Training)

1. Create empty database `ErcoView_Training`.
2. Run `schema/` scripts (tables, FKs).
3. Run `procedures/` scripts.
4. Create app SQL login / users per org policy (not stored in git).
5. Seed minimal lookup data if required (separate controlled seed scripts only).

## Client connection reminder

Runtime uses `GetConnectionString()` + `secrets/sql.env` (git-crypt). Design-time strings in `app.config` may differ. See [`docs/database.md`](../docs/database.md).

## Coverage goal

≥ 95% of procedure names listed in `docs/reference/stored-procedures.md` should exist as scripts under `db/procedures/` after export.
