using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Queries.GetListingsForLP
{
    public class GetListingsForLPQueryHandler : IRequestHandler<GetListingsForLPQuery, ListingsForLPVM>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetListingsForLPQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListingsForLPVM> Handle(GetListingsForLPQuery request, CancellationToken cancellationToken)
        {
            int page = request.Page ?? 1;
            int pageSize = request.PageSize ?? 8;

            ListingsForLPVM vm = new ListingsForLPVM();

            if (request.Page == null)
            {
                vm.Lookup = new LookupDto
                {
                    OfferTypes = await _context.OfferTypes.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    PropertyTypes = await _context.PropertyTypes.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    PropertyLayouts = await _context.PropertyLayouts.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    BuildingTypes = await _context.BuildingTypes.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    OwnershipTypes = await _context.OwnershipTypes.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    PropertyConditions = await _context.PropertyConditions.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    LandTypes = await _context.LandTypes.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    Furnishings = await _context.Furnishings.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    EnergyCertificates = await _context.EnergyCertificates.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                    PropertyFeatures = await _context.PropertyFeatures.ProjectTo<IdName>(_mapper.ConfigurationProvider).ToListAsync(),
                };

                //TODO: add vip & hot listings

                vm.VipListings = await _context.Listings
                    .Include(x => x.PropertyType)
                    .Include(x => x.PropertyLayout)
                    .Include(x => x.Images)
                    .OrderByDescending(x => x.Created)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ProjectTo<ListingDto>(_mapper.ConfigurationProvider)
                    .ToListAsync();

                vm.HotListings = await _context.Listings
                    .Include(x => x.PropertyType)
                    .Include(x => x.PropertyLayout)
                    .Include(x => x.Images)
                    .OrderByDescending(x => x.Created)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ProjectTo<ListingDto>(_mapper.ConfigurationProvider)
                    .ToListAsync();
            }

            

            vm.LatestListings = await _context.Listings
                .Include(x => x.PropertyType)
                .Include(x => x.PropertyLayout)
                .Include(x => x.Images)
                .OrderByDescending(x => x.Created)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ProjectTo<ListingDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            int totalListings = await _context.Listings.CountAsync();

            vm.PageCount = totalListings / pageSize;

            return vm;
        }
    }
}
