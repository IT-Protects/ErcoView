# Database notes

## Environments

| Catalog | Purpose |
|---------|---------|
| `ErcoView_Training` | Default for development and experiments |
| `ErcoView_Live` | Production — change-controlled |

Promote SP/schema changes **Training → review → Live**.

## Drift checklist

When Live and Training diverge, record here:

| Date | Object | Training | Live | Action |
|------|--------|----------|------|--------|
| | | | | |

## Conventions

- Prefer `sp` prefix for procedures (existing client convention).
- Keep parameter names stable; client uses `AddWithValue` widely.
- Column name typos used by the client (e.g. `ONE_CALL_EXPERATION_DATE`) require coordinated renames.
- Password storage: target hashed columns — see [`docs/design/auth-password-hashing.md`](../docs/design/auth-password-hashing.md).

## Security

- No production passwords in scripts.
- No full data exports in this repo.
- GRANT scripts should use roles, not shared passwords in source.
