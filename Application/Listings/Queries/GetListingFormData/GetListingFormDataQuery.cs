using MediatR;

namespace Application.Listings.Queries.GetListingFormData
{
    public class GetListingFormDataQuery : IRequest<ListingFormDataVM>
    {
        public long? Id { get; set; }
    }
}
