using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PropertyFeature : MultiLangNameEntity
    {
        public ICollection<ListingFeature> ListingFeatures { get; set; }
    }
}
