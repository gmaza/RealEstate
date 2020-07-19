using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Commands.UpdateListing
{
    public class UpdateListingCommandHandler : IRequestHandler<UpdateListingCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UpdateListingCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<Unit> Handle(UpdateListingCommand request, CancellationToken cancellationToken)
        {
            var listing = await _context.Listings.FindAsync(request.Id);
            _mapper.Map(request, listing);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
