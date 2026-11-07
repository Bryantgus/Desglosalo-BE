# Desglosalo (backend)

System for a business that manufactures windows, doors and more. It is built feature by feature, in small steps.

**First feature:** [Breakdowns](docs/features/breakdowns.md) - automatic calculation of the pieces (desglose) of a window from its opening.

## Stack
- .NET 10 (LTS), C# 14, ASP.NET Core Controllers
- Clean Architecture: Domain -> Application -> Infrastructure -> Api
- SQL Server (planned), xUnit for tests

## Structure
```
src/
  Desglosalo.Domain          entities and pure business rules
  Desglosalo.Application     use cases, DTOs, interfaces
  Desglosalo.Infrastructure  persistence and external adapters
  Desglosalo.Api             controllers, HTTP, composition root
tests/
  Desglosalo.UnitTests
docs/
  architecture.md            what every file does (keep updated)
  features/                  one doc per feature
```

## Run
```
dotnet build
dotnet test
dotnet run --project src/Desglosalo.Api
```

## Conventions
- All measures are **inches**, sent over the API as **integer sixteenths** (1 1/2" = 24).
- Domain vocabulary stays in Spanish: desglose, hueco, vias, riel-cabezal, jamba, lateral, ruleta, tipo de perfil.
- Every feature gets a doc in `docs/features/` (start from `_template.md`).
