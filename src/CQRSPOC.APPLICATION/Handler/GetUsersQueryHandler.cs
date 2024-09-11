using CQRSPOC.APPLICATION.Manager.Contract;
using CQRSPOC.APPLICATION.Queries;
using CQRSPOC.ENTITY.ResponseModel;
using MediatR;

namespace CQRSPOC.APPLICATION.Handler;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, UserResponseList>
{
    private readonly IUserManager userManager;

    public GetUsersQueryHandler(IUserManager _userManager) => (userManager) = (_userManager);

    public async Task<UserResponseList> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return await userManager.GetUsersAsync(request.UserFilterModel);
    }
}
