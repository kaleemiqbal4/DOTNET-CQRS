using CQRSPOC.APPLICATION.Command;
using CQRSPOC.APPLICATION.Manager.Contract;
using CQRSPOC.ENTITY.ResponseModel;
using MediatR;

namespace CQRSPOC.APPLICATION.Handler;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserResponse>
{
    private readonly IUserManager userManager;

    public CreateUserCommandHandler(IUserManager _userManager) => userManager = _userManager;

    public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
       return await userManager.SaveUserAsync(request.UserModel);
    }
}
