# Rule: layering
- Domain must not reference any other project or NuGet package with I/O.
- Application references only Domain.
- Infrastructure references Application.
- Api references Application and Infrastructure (composition root only).
- Controllers call `I...Service` and map nothing else; no EF types leave Infrastructure.
- Tests: pure domain logic is tested in `UnitTests/<Feature>/` without mocks.
