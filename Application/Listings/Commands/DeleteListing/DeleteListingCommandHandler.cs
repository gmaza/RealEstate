using Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Commands.DeleteListing
{
    public class DeleteListingCommandHandler : IRequestHandler<DeleteListingCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteListingCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteListingCommand request, CancellationToken cancellationToken)
        {
            var listing = await _context.Listings.FindAsync(request.Id);

            _context.Listings.Remove(listing);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
