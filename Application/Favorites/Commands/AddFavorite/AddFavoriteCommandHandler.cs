using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Favorites.Commands.AddFavorite
{
    public class AddFavoriteCommandHandler : IRequestHandler<AddFavoriteCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;

        public AddFavoriteCommandHandler(IApplicationDbContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }

        public async Task<Unit> Handle(AddFavoriteCommand request, CancellationToken cancellationToken)
        {
            bool listingExists = await _context.Listings.AnyAsync(x => x.Id == request.Id);

            if (!listingExists)
                throw new BadRequestException("Listing with given ID doesn't exists.");

            var user = await _context.ApplicationUsers.FirstAsync(x => x.IdentityUserId == _currentUserService.UserId);

            bool favoriteAlreadyExists = await _context.FavoriteListings.AnyAsync(x => x.ApplicationUserId == user.Id && x.ListingId == request.Id);

            if (favoriteAlreadyExists)
                throw new BadRequestException("This listing is already added to user's favorite listings.");

            _context.FavoriteListings.Add(new FavoriteListing
            {
                ApplicationUserId = user.Id,
                ListingId = request.Id
            });

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
