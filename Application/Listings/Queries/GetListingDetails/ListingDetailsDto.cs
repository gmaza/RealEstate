using Application.Common.Mappings;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.Listings.Queries.GetListingDetails
{
    public class ListingDetailsDto : IMapFrom<Listing>
    {
        public long? Id { get; set; }
        public string OfferType { get; set; }
        public string PropertyType { get; set; }
        public string PropertyLayout { get; set; }
        public string BuildingType { get; set; }
        public string OwnershipType { get; set; }
        public string PropertyCondition { get; set; }
        public string LandType { get; set; }
        public int? Floor { get; set; }
        public int Area { get; set; }
        public string Description { get; set; }
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

        public List<IdName> ListingFeatures { get; set; }
        public List<ImageDto> Images { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Listing, ListingDetailsDto>()
                .ForMember(x => x.OfferType, x => x.MapFrom(l => l.OfferType.GetLocalizedName()))
                .ForMember(x => x.PropertyType, x => x.MapFrom(l => l.PropertyType.GetLocalizedName()))
                .ForMember(x => x.PropertyLayout, x => x.MapFrom(l => l.PropertyLayout.GetLocalizedName()))
                .ForMember(x => x.BuildingType, x => x.MapFrom(l => l.BuildingType.GetLocalizedName()))
                .ForMember(x => x.OwnershipType, x => x.MapFrom(l => l.OwnershipType.GetLocalizedName()))
                .ForMember(x => x.PropertyCondition, x => x.MapFrom(l => l.PropertyCondition.GetLocalizedName()))
                .ForMember(x => x.LandType, x => x.MapFrom(l => l.LandType.GetLocalizedName()))
                .ForMember(x => x.Description, x => x.MapFrom(l => l.GetLocalizedDesciption()));
        }
    }

    public class ImageDto
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
    }
}
