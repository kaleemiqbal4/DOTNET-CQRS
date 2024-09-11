using CQRSPOC.ENTITY.Entity;
using CQRSPOC.ENTITY.RequestModel;
using CQRSPOC.ENTITY.ResponseModel;
using MediatR;

namespace CQRSPOC.APPLICATION.Command
{
    public class CreateUserCommand : IRequest<UserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
       public UserModel UserModel { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userEntity"></param>
        public CreateUserCommand(UserModel userModel) 
        {
            UserModel = userModel;
        }
    }
}
