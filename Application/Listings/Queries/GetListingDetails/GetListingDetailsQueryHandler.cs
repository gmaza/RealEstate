using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Queries.GetListingDetails
{
    public class GetListingDetailsQueryHandler : IRequestHandler<GetListingDetailsQuery, ListingDetailsDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetListingDetailsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListingDetailsDto> Handle(GetListingDetailsQuery request, CancellationToken cancellationToken)
        {
            var listing = await _context.Listings
                .Include(x => x.OfferType)
                .Include(x => x.PropertyType)
                .Include(x => x.PropertyLayout)
                .Include(x => x.BuildingType)
                .Include(x => x.OwnershipType)
                .Include(x => x.PropertyCondition)
                .Include(x => x.LandType)
                .Include(x => x.Features)
                .Include(x => x.Images)
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            return _mapper.Map<ListingDetailsDto>(listing);
        }
    }
}
