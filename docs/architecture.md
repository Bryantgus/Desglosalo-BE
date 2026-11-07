# Architecture - file by file

> Keep this file updated on EVERY change (see CLAUDE.md).

Dependency flow: `Api -> Infrastructure -> Application -> Domain`.

## Root
| File | Purpose |
|---|---|
| `Desglosalo.slnx` | Solution file listing all projects. |
| `README.md` | Project overview, structure, how to run, conventions. |
| `CLAUDE.md` | Instructions for Claude, including the rule to update this file. |
| `.claude/rules/architecture-sync.md` | Rule: update this doc on every file change. |
| `.claude/rules/clean-architecture.md` | Rule: layer dependencies and responsibilities. |
| `.claude/rules/measures.md` | Rule: inches as integer sixteenths. |
| `.editorconfig` | Code style settings. |
| `.gitignore` | Git ignore for .NET. |

## docs/
| File | Purpose |
|---|---|
| `docs/architecture.md` | This file. |
| `docs/features/_template.md` | Template for new feature docs. |
| `docs/features/breakdowns.md` | Breakdowns feature: goal, rules, API, open questions. |

## src/Desglosalo.Domain (no dependencies)
| File | Purpose |
|---|---|
| `Common/AuditableEntity.cs` | Base entity: Guid v7 `Id`, `CreatedAt`, `UpdatedAt`. |
| `Breakdowns/ProfileType.cs` | Entity: "tipo de perfil" (P65, P92, Tradicional). |
| `Breakdowns/PieceDefinition.cs` | Record: rule for one piece (dimension, resta, divisor, adjust, quantity) plus `PieceDimension` enum. |
| `Breakdowns/BreakdownPiece.cs` | Record: one calculated piece (name, length in sixteenths, quantity). |
| `Breakdowns/BreakdownCalculator.cs` | Static pure calculation of pieces from an opening. Not implemented yet. |

## src/Desglosalo.Application (-> Domain)
| File | Purpose |
|---|---|
| `DependencyInjection.cs` | `AddApplication()`: registers application services. |
| `Breakdowns/IBreakdownService.cs` | Use-case contract for calculating a breakdown. |
| `Breakdowns/BreakdownService.cs` | Implementation of the contract. Not implemented yet. |
| `Breakdowns/IBreakdownRepository.cs` | Repository contract: loads profile type and piece definitions. Implemented in Infrastructure. |
| `Breakdowns/Dtos/CalculateBreakdownRequest.cs` | Request DTO: profile type id, width and height in sixteenths. |
| `Breakdowns/Dtos/BreakdownResponse.cs` | Response DTOs: `BreakdownResponse` and `BreakdownPieceDto`. |

## src/Desglosalo.Infrastructure (-> Application)
| File | Purpose |
|---|---|
| `DependencyInjection.cs` | `AddInfrastructure()`: registers persistence and adapters (empty for now). |
| `Persistence/Repositories/BreakdownRepository.cs` | Implements `IBreakdownRepository`. Not implemented yet (no DB wired). |

## src/Desglosalo.Api (-> Application, Infrastructure)
| File | Purpose |
|---|---|
| `Program.cs` | Composition root: registers layers, maps controllers. |
| `Controllers/BreakdownsController.cs` | `POST /api/breakdowns/calculate`. |
| `appsettings*.json` | Configuration. |
| `Properties/launchSettings.json` | Local launch profiles. |

## tests/Desglosalo.UnitTests (-> Domain, Application)
| File | Purpose |
|---|---|
| `Breakdowns/BreakdownCalculatorTests.cs` | Placeholder for calculator tests. |


