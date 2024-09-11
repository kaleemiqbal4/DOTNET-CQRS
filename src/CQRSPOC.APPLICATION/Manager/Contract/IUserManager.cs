using CQRSPOC.ENTITY.RequestModel;
using CQRSPOC.ENTITY.ResponseModel;

namespace CQRSPOC.APPLICATION.Manager.Contract;

public interface IUserManager
{
    Task<UserResponse> SaveUserAsync(UserModel userModel);

    Task<UserResponseList> GetUsersAsync(UserFilterModel userFilterModel);
}
