# Desglosalo backend - instructions for Claude

ASP.NET (.NET 10) Clean Architecture backend for a window/door manufacturing business. Features are added one at a time.

## MANDATORY: keep docs/architecture.md updated
`docs/architecture.md` describes every file in the project and what it contains.
**Any change that adds, removes, renames or changes the responsibility of a file MUST update `docs/architecture.md` in the same change.** Do not finish a task without it.
Also update the feature doc in `docs/features/` when behavior changes.

## Architecture rules
- Dependencies point inward: Api -> Infrastructure -> Application -> Domain. Domain references nothing.
- Domain: entities and pure logic, no framework or I/O.
- Application: use cases (`I...Service`), DTOs, abstractions that Infrastructure implements.
- Infrastructure: EF Core, external adapters; registered in `DependencyInjection.cs`.
- Api: thin Controllers, no business logic.
- Organize Application and Domain by feature folder (e.g. `Breakdowns/`).

## Domain conventions
- Measures in inches, stored/transferred as integer sixteenths. Never meters, never floats.
- Keep Spanish domain terms (desglose, hueco, vias, jamba, ruleta, tipo de perfil).
- Never invent real formula/resta values; they come from the user (seed data). Ask if unknown.

## New feature checklist
1. Copy `docs/features/_template.md` to `docs/features/<feature>.md` and fill it in.
2. Add folders in Domain/Application (and Api controller).
3. Add tests in `tests/Desglosalo.UnitTests/<Feature>/`.
4. Update `docs/architecture.md` and `README.md` if needed.

More detail in `.claude/rules/`.
