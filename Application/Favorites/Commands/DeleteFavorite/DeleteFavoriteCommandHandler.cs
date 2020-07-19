using Application.Common.Exceptions;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Favorites.Commands.DeleteFavorite
{
    public class DeleteFavoriteCommandHandler : IRequestHandler<DeleteFavoriteCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;

        public DeleteFavoriteCommandHandler(IApplicationDbContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }

        public async Task<Unit> Handle(DeleteFavoriteCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.ApplicationUsers.FirstAsync(x => x.IdentityUserId == _currentUserService.UserId);

            var favorite = await _context.FavoriteListings.FirstOrDefaultAsync(x => x.ApplicationUserId == user.Id && x.ListingId == request.Id);

            if (favorite == null)
                throw new BadRequestException("User doesn't have this listing in favorites.");

            _context.FavoriteListings.Remove(favorite);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
