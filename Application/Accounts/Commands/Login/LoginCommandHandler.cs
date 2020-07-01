using Application.Common.Exceptions;
using Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Accounts.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, UserDto>
    {
        private readonly IIdentityService _identityService;

        public LoginCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<UserDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            UserDto user = await _identityService.SignInUserAsync(request.Email, request.Password);

            if (user == null)
                throw new BadRequestException("Username or password is incorrect");

            return user;
        }
    }
}
