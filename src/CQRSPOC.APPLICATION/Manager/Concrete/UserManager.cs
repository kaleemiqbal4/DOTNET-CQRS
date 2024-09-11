using CQRSPOC.APPLICATION.Manager.Contract;
using CQRSPOC.ENTITY.RequestModel;
using CQRSPOC.ENTITY.ResponseModel;

namespace CQRSPOC.APPLICATION.Manager.Concrete;

public class UserManager : IUserManager
{
    public UserManager()
    {
        
    }

    public async Task<UserResponse> SaveUserAsync(UserModel userModel)
    {
        await Task.CompletedTask;
        return new UserResponse();
    }

    public async Task<UserResponseList> GetUsersAsync(UserFilterModel userFilterModel)
    {
        await Task.CompletedTask;
        return new UserResponseList();
    }
}
