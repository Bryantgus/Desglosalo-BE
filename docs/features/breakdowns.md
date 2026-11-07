# Feature: Breakdowns (Desglose)

## Goal
Given the opening (hueco) of a window, compute every piece (profiles and glass) needed to build it.

## Inputs / outputs
- **Input:** profile type (`ProfileTypeId`), width and height of the opening in sixteenths of an inch.
- **Output:** list of pieces: name, length (sixteenths), quantity.

## Business rules (to confirm with the owner)
- Each piece = opening dimension (width or height) - resta, optionally divided by a divisor, plus an adjust.
- Convencional family pieces: riel-cabezal, jamba, lateral, ruleta, cristal ancho, cristal alto.
- A tipo de perfil (P65, P92, Tradicional) only changes resta/divisor/adjust.
- Vias (2, 3...) change riel-cabezal.
- Real values are NOT defined yet; they will be supplied as seed data.

## Domain model
`ProfileType`, `PieceDefinition`, `BreakdownPiece`, `BreakdownCalculator` (see docs/architecture.md).

## API
`POST /api/breakdowns/calculate`
```json
{ "profileTypeId": "guid", "widthSixteenths": 576, "heightSixteenths": 768 }
```
Response: `{ "pieces": [ { "name": "Jamba", "lengthSixteenths": 750, "quantity": 2 } ] }`

## Open questions
- Exact formula and rounding per piece.
- Where profile types/piece definitions are stored (seed vs table).
- Glass thickness / color handling.

## Status
Scaffold only. `BreakdownCalculator` and `BreakdownService` throw `NotImplementedException`.
