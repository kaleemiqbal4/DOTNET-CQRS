using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPOC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApiControllerBase : ControllerBase
{
    private readonly IMediator mediator;

    public ApiControllerBase(IMediator _mediator) => (mediator) = (_mediator);

    protected async Task<TResult> QueryAsync<TResult>(IRequest<TResult> query)
    {
        return await mediator.Send(query);
    }

    protected async Task<TResult> CommandAsync<TResult>(IRequest<TResult> query)
    {
        return await mediator.Send(query);
    }

    protected IActionResult Single<TResult>(TResult result)
    {
        return IsNull(result) ? NoContent() as IActionResult : Ok(result);
    }

    protected IActionResult GetItems<TResult>(IEnumerable<TResult> result)
    {
        return IsNullOrEmpty(result) ? NoContent() as IActionResult : Ok(result);
    }

    public static bool IsNull<TResult>(TResult result)
    {
        return result == null || !result.Equals(default(TResult));
    }

    public static bool IsNullOrEmpty<TResult>(IEnumerable<TResult> result)
    {
        return result  == null || !result.Any();
    }

}
