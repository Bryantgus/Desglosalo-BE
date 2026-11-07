using Desglosalo.Application.Breakdowns;
using Desglosalo.Domain.Breakdowns;

namespace Desglosalo.Infrastructure.Persistence.Repositories;

public sealed class BreakdownRepository : IBreakdownRepository
{
    public Task<ProfileType?> GetProfileTypeAsync(Guid profileTypeId, CancellationToken ct = default)
        => throw new NotImplementedException();

    public Task<IReadOnlyList<PieceDefinition>> GetPieceDefinitionsAsync(Guid profileTypeId, CancellationToken ct = default)
        => throw new NotImplementedException();
}
