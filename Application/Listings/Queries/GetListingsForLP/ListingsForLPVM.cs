using System.Collections.Generic;

namespace Application.Listings.Queries.GetListingsForLP
{
    public class ListingsForLPVM
    {
        public LookupDto Lookup { get; set; }
        public List<ListingDto> VipListings { get; set; }
        public List<ListingDto> HotListings { get; set; }
        public List<ListingDto> LatestListings { get; set; }
        public int PageCount { get; set; }
    }
}
