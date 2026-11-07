namespace Desglosalo.Domain.Breakdowns;

/// <summary>One calculated row of a breakdown (desglose). Length in sixteenths of an inch.</summary>
public sealed record BreakdownPiece(string Name, int LengthSixteenths, int Quantity);
