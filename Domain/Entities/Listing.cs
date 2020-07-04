using Domain.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Listing : AuditableEntity
    {
        public long Id { get; set; }
        public Guid OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

        public int OfferTypeId { get; set; }
        public OfferType OfferType { get; set; }
        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }
        public int? PropertyLayoutId { get; set; }
        public PropertyLayout PropertyLayout { get; set; }
        public int? BuildingTypeId { get; set; }
        public BuildingType BuildingType { get; set; }
        public int? OwnershipTypeId { get; set; }
        public OwnershipType OwnershipType { get; set; }
        public int? PropertyConditionId { get; set; }
        public PropertyCondition PropertyCondition { get; set; }
        public int? LandTypeId { get; set; }
        public LandType LandType { get; set; }
        public int? Floor { get; set; }
        public int Area { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionRU { get; set; }
        public string DescriptionCZ { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime ValidUntil { get; set; }

        //Address
        public string City { get; set; }
        public string Municipality { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string PostCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        //Price
        public decimal Price { get; set; }
        public decimal? Fees { get; set; }
        public decimal? Deposit { get; set; }

        public ICollection<ListingFeature> Features { get; set; }
        public ICollection<ListingImage> Images { get; set; }
    }
}
