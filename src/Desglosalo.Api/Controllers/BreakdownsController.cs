using Desglosalo.Application.Breakdowns;
using Desglosalo.Application.Breakdowns.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Desglosalo.Api.Controllers;

[ApiController]
[Route("api/breakdowns")]
public class BreakdownsController(IBreakdownService service) : ControllerBase
{
    [HttpPost("calculate")]
    public async Task<ActionResult<BreakdownResponse>> Calculate(CalculateBreakdownRequest request, CancellationToken ct)
        => Ok(await service.CalculateAsync(request, ct));
}
