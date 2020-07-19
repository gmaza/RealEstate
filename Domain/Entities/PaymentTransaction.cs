using Domain.Common;
using System;

namespace Domain.Entities
{
    public class PaymentTransaction : AuditableEntity
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionCZ { get; set; }
        public string DescriptionRU { get; set; }
    }
}
