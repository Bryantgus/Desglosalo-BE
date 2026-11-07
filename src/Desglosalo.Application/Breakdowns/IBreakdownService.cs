using Desglosalo.Application.Breakdowns.Dtos;

namespace Desglosalo.Application.Breakdowns;

public interface IBreakdownService
{
    Task<BreakdownResponse> CalculateAsync(CalculateBreakdownRequest request, CancellationToken ct = default);
}
