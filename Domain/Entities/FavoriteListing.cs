using System;

namespace Domain.Entities
{
    public class FavoriteListing
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public long ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
