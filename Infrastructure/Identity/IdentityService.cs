using Application.Accounts.Commands.Login;
using Application.Common.Interfaces;
using Application.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;

        public IdentityService(UserManager<User> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        public async Task<string> GetUserNameAsync(Guid userId)
        {
            var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

            return user.UserName;
        }
        public async Task<(Result Result, Guid UserId)> CreateUserAsync(string userName, string password)
        {
            var user = new User
            {
                UserName = userName,
                Email = userName
            };

            var result = await _userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<Result> DeleteUserAsync(Guid userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }

        public async Task<Result> DeleteUserAsync(User user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }

        public async Task<bool> UserWithEmailExists(string email)
        {
            var user = await _userManager.FindByNameAsync(email);

            return user != null;
        }

        public async Task<(Result Result, Guid? userId)> SignInUserAsync(string userName, string password)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var passwordCorrect = await _userManager.CheckPasswordAsync(user, password);
            
            if (!passwordCorrect)
                return (Result.Failure(new string[] {"Username or password is incorrect"}), null);

            return (Result.Success(), user.Id);
        }


        public async Task<Result> UpdateUserEmailAsync(Guid userId, string email)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            user.Email = email;
            user.UserName = email;

            var result = await _userManager.UpdateAsync(user);

            return result.ToApplicationResult();
        }
    }
}
