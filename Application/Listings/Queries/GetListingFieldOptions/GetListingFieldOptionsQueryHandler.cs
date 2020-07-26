using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Listings.Queries.GetListingFieldOptions
{
    public class GetListingFieldOptionsQueryHandler : IRequestHandler<GetListingFieldOptionsQuery, ListingFieldOptionsDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetListingFieldOptionsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListingFieldOptionsDto> Handle(GetListingFieldOptionsQuery request, CancellationToken cancellationToken)
        {

            var listingOptions = new ListingFieldOptionsDto
            {
                OfferTypes = await _context.OfferTypes.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                PropertyTypes = await _context.PropertyTypes.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                PropertyLayouts = await _context.PropertyLayouts.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                BuildingTypes = await _context.BuildingTypes.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                OwnershipTypes = await _context.OwnershipTypes.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                PropertyConditions = await _context.PropertyConditions.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                LandTypes = await _context.LandTypes.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken),
                Furnishings = await _context.Furnishings.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                EnergyCertificates = await _context.EnergyCertificates.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
                PropertyFeatures = await _context.PropertyFeatures.OrderBy(x => x.Id)
                    .ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken),
            };

            return listingOptions;
        }
    }
}
