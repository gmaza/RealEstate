using System;

namespace Domain.Entities
{
    public class ListingImage
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public long ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
