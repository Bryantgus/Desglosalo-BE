namespace Desglosalo.Domain.Common;

/// <summary>Base class for every persisted entity. Guid v7 key plus audit timestamps.</summary>
public abstract class AuditableEntity
{
    public Guid Id { get; protected set; } = Guid.CreateVersion7();
    public DateTimeOffset CreatedAt { get; protected set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; protected set; }
}
