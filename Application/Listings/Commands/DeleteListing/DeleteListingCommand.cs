using MediatR;

namespace Application.Listings.Commands.DeleteListing
{
    public class DeleteListingCommand : IRequest
    {
        public long Id { get; set; }
    }
}
