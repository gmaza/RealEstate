using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Commands
{
    public class CreateListingCommandHandler : IRequestHandler<CreateListingCommand, long>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IMapper _mapper;

        public CreateListingCommandHandler(IApplicationDbContext context, ICurrentUserService currentUserService, IMapper mapper)
        {
            _context = context;
            _currentUserService = currentUserService;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateListingCommand request, CancellationToken cancellationToken)
        {
            var listing = _mapper.Map<Listing>(request);

            Guid currentUserId = _currentUserService.UserId.GetValueOrDefault();
            var applicationUser = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.IdentityUserId == currentUserId);

            listing.OwnerId = applicationUser.Id;
            _context.Listings.Add(listing);


            await _context.SaveChangesAsync(cancellationToken);

            return listing.Id;
        }
    }
}
