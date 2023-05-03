using Microsoft.AspNetCore.Mvc;
using Scheduler.Models;

namespace Scheduler.Services.UserService
{
    public interface IUserService
    {
        Task<ResponseService<User>> AddUser(User user);
    }
}
