using Application.Common.Mappings;
using MediatR;

namespace Application.Accounts.Commands.Register
{
    public class RegisterCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
