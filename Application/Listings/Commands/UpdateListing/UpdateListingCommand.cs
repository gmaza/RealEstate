using Application.Common.Mappings;
using Domain.Entities;
using MediatR;
using System;

namespace Application.Listings.Commands.UpdateListing
{
    public class UpdateListingCommand : IRequest, IMapTo<Listing>
    {
        public long Id { get; set; }
        public int OfferTypeId { get; set; }
        public int PropertyTypeId { get; set; }
        public int? PropertyLayoutId { get; set; }
        public int? BuildingTypeId { get; set; }
        public int? OwnershipTypeId { get; set; }
        public int? PropertyConditionId { get; set; }
        public int? LandTypeId { get; set; }
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
    }
}
