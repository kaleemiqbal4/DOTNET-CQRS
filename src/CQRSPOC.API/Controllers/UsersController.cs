using CQRSPOC.APPLICATION.Command;
using CQRSPOC.APPLICATION.Queries;
using CQRSPOC.ENTITY.RequestModel;
using CQRSPOC.ENTITY.ResponseModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPOC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ApiControllerBase
{
    private readonly IMediator mediator;

    private readonly ILogger<UsersController> logger;

    public UsersController(IMediator _mediator, ILogger<UsersController> logger): base(_mediator)
    {
        mediator = _mediator;
        this.logger = logger;
    }

    [HttpPost]
    [Produces(typeof(UserResponse))]
    public async Task<IActionResult> CreateUser([FromBody] UserModel userModel)
    {
        var command = new CreateUserCommand(userModel);
        var result =  await CommandAsync(command);
        return Ok(result);
    }

    [HttpGet]
    [Produces(typeof(UserResponseList))]
    public async Task<IActionResult> GetUserAsync([FromQuery] UserFilterModel userFilterModel)
    {
        var command = new GetUsersQuery(userFilterModel);
        var result = await QueryAsync(command);
        return Ok(result);
    }
}
