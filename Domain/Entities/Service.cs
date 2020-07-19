using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Service : MultiLangNameEntity
    {
        public decimal CostPerDay { get; set; }
        public ICollection<ListingService> ListingServices { get; set; }
    }
}
