namespace Desglosalo.Domain.Breakdowns;

/// <summary>Pure domain logic: opening + piece definitions -> calculated pieces.</summary>
public static class BreakdownCalculator
{
    public static IReadOnlyList<BreakdownPiece> Calculate(
        int widthSixteenths,
        int heightSixteenths,
        IReadOnlyList<PieceDefinition> definitions)
        => throw new NotImplementedException("Pending: formula to be defined in docs/features/breakdowns.md");
}
