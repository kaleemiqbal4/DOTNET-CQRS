using CQRSPOC.ENTITY.RequestModel;
using CQRSPOC.ENTITY.ResponseModel;
using MediatR;

namespace CQRSPOC.APPLICATION.Queries;

public class GetUsersQuery : IRequest<UserResponseList>
{
    public UserFilterModel UserFilterModel { get; }

    public GetUsersQuery(UserFilterModel userFilterModel) => UserFilterModel = userFilterModel;
}
