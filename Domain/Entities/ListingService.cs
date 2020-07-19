using Domain.Common;
using System;

namespace Domain.Entities
{
    public class ListingService : AuditableEntity
    {
        public Guid Id { get; set; }
        public long ListingId { get; set; }
        public Listing Listing { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public DateTime EndDate { get; set; }
    }
}