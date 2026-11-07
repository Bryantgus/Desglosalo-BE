namespace Desglosalo.Application.Breakdowns.Dtos;

public sealed record BreakdownResponse(IReadOnlyList<BreakdownPieceDto> Pieces);

public sealed record BreakdownPieceDto(string Name, int LengthSixteenths, int Quantity);
