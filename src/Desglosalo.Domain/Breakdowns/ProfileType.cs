using Desglosalo.Domain.Common;

namespace Desglosalo.Domain.Breakdowns;

/// <summary>
/// "Tipo de perfil" (e.g. P65, P92, Tradicional): the template holding the
/// discount (resta), divisor and adjust for each piece. Real values are seed data, not code.
/// </summary>
public class ProfileType : AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
}
