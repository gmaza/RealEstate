using MediatR;

namespace Application.Accounts.Commands.UpdatePersonalInfo
{
    public class UpdatePersonalInfoCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
