using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public abstract class ListingMultiLangNameEntity : MultiLangNameEntity
    {
        public ICollection<Listing> Listings { get; set; }
    }
}
