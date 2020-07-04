using Application.Accounts.Commands.Login;
using Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(Guid userId);
        Task<(Result Result, Guid? userId)> SignInUserAsync(string userName, string password);
        Task<(Result Result, Guid UserId)> CreateUserAsync(string userName, string password);
        Task<Result> DeleteUserAsync(Guid userId);
        Task<bool> UserWithEmailExists(string email);
    }
}
