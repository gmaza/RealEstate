using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Queries.GetListingFormData
{
    public class GetListingFormDataQueryHandler : IRequestHandler<GetListingFormDataQuery, ListingFormDataVM>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetListingFormDataQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListingFormDataVM> Handle(GetListingFormDataQuery request, CancellationToken cancellationToken)
        {
            ListingFormDataVM vm = new ListingFormDataVM();

            vm.FieldOptions = new ListingFieldOptions
            {
                OfferTypes = await _context.OfferTypes.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                PropertyTypes = await _context.PropertyTypes.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                PropertyLayouts = await _context.PropertyLayouts.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                BuildingTypes = await _context.BuildingTypes.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                OwnershipTypes = await _context.OwnershipTypes.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                PropertyConditions = await _context.PropertyConditions.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                LandTypes = await _context.LandTypes.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                Furnishings = await _context.Furnishings.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                EnergyCertificates = await _context.EnergyCertificates.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                PropertyFeatures = await _context.PropertyFeatures.OrderBy(x => x.Id).ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
            };

            if (request.Id != null)
            {
                //TODO map existing listing
            }

            return vm;
        }
    }
}
