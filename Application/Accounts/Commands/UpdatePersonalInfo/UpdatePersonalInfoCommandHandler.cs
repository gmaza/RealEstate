using Application.Common.Exceptions;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Accounts.Commands.UpdatePersonalInfo
{
    public class UpdatePersonalInfoCommandHandler : IRequestHandler<UpdatePersonalInfoCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IIdentityService _identityService;

        public UpdatePersonalInfoCommandHandler(IApplicationDbContext context, ICurrentUserService currentUserService, IIdentityService identityService)
        {
            _context = context;
            _currentUserService = currentUserService;
            _identityService = identityService;
        }


        public async Task<Unit> Handle(UpdatePersonalInfoCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.ApplicationUsers.FirstAsync(x => x.IdentityUserId == _currentUserService.UserId);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;

            var result = await _identityService.UpdateUserEmailAsync(user.IdentityUserId, request.Email);

            if (!result.Succeeded)
                throw new BadRequestException();

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
