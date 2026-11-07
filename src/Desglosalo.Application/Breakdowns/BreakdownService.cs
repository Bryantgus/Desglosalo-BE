using Desglosalo.Application.Breakdowns.Dtos;

namespace Desglosalo.Application.Breakdowns;

public sealed class BreakdownService(IBreakdownRepository repository) : IBreakdownService
{
    public Task<BreakdownResponse> CalculateAsync(CalculateBreakdownRequest request, CancellationToken ct = default)
        => throw new NotImplementedException();
}

