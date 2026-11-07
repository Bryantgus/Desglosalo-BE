namespace Desglosalo.Domain.Breakdowns;

/// <summary>
/// Rule to compute one piece (riel-cabezal, jamba, lateral, ruleta, cristal...)
/// from the opening (hueco). All measures are in sixteenths of an inch.
/// </summary>
public sealed record PieceDefinition(
    string Name,
    PieceDimension Dimension,
    int RestaSixteenths,
    int Divisor,
    int AdjustSixteenths,
    int Quantity);

public enum PieceDimension
{
    Width,
    Height
}
