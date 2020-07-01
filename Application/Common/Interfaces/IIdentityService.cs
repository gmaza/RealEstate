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
        Task<string> GetUserNameAsync(string userId);
        Task<UserDto> SignInUserAsync(string userName, string password);
        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password, string firstName, string lastName);
        Task<Result> DeleteUserAsync(string userId);
        Task<bool> UserWithEmailExists(string email);
    }
}
