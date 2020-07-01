using MediatR;

namespace Application.Accounts.Commands.Login
{
    public class LoginCommand : IRequest<UserDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
