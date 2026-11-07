using Desglosalo.Domain.Breakdowns;

namespace Desglosalo.Application.Breakdowns;

/// <summary>Persistence contract for breakdown data. Implemented in Infrastructure.</summary>
public interface IBreakdownRepository
{
    Task<ProfileType?> GetProfileTypeAsync(Guid profileTypeId, CancellationToken ct = default);

    Task<IReadOnlyList<PieceDefinition>> GetPieceDefinitionsAsync(Guid profileTypeId, CancellationToken ct = default);
}
