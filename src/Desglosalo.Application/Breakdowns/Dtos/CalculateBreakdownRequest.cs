namespace Desglosalo.Application.Breakdowns.Dtos;

/// <summary>Opening measures travel as integer sixteenths of an inch.</summary>
public sealed record CalculateBreakdownRequest(Guid ProfileTypeId, int WidthSixteenths, int HeightSixteenths);
