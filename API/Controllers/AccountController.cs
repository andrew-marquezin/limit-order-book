using Application.UseCases.Account.GetBalance;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    [HttpGet("{id:guid}/balance")]
    public async Task<IActionResult> GetBalance(
        [FromRoute] Guid id,
        GetBalanceQueryHandler handler,
        CancellationToken cancellationToken)
    {
        var query = new GetBalanceQuery(id);
        var result = await handler.Handle(query, cancellationToken);

        if (result.IsFailure)
        {
            return NotFound(result.Error);
        }

        return Ok(result.Value);
    }
}