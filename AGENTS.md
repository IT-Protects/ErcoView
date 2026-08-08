# ErcoView — agent rules

## Secrets and git-crypt

**Always use git-crypt for secrets in this repo.**

- Sensitive paths are listed in `.gitattributes` and encrypted with git-crypt.
- Prefer putting new credentials under `secrets/` (encrypted) rather than hardcoding in `.vb` / config.
- Before committing secrets: ensure `git-crypt status` shows them as encrypted.
- Never commit the git-crypt key. Unlock with `git-crypt unlock <keyfile>` (key stored outside the repo).
- Plaintext credentials may still exist in **old git history**; do not reintroduce them.

See also: global rule `git-crypt` and `secrets/README.md`.
