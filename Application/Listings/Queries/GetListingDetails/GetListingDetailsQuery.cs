using MediatR;

namespace Application.Listings.Queries.GetListingDetails
{
    public class GetListingDetailsQuery : IRequest<ListingDetailsDto>
    {
        public long Id { get; set; }
    }
}
