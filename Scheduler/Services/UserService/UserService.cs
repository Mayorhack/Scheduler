using Scheduler.Models;

namespace Scheduler.Services.UserService
{
    public class UserService : IUserService
    {
        public async Task<ResponseService<User>> AddUser(User user)
        {
            var responseSevice=new ResponseService<User> { Data=user};
            return responseSevice;
        }
    }
}
