using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Application.Listings.Queries.GetListingsForLP
{
    public class ListingDto : IMapFrom<Listing>
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<string> ImageUrls { get; set; }
        public bool IsFavourite { get; set; }
        public string PropertyLayout { get; set; }
        public string PropertyType { get; set; }
        public int Area { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Listing, ListingDto>()
                .ForMember(x => x.Title, x => x.MapFrom(li => string.Join(", ", li.City, li.Municipality, li.Street)))
                .ForMember(x => x.PropertyLayout, x => x.MapFrom(li => li.PropertyLayout != null ? li.PropertyLayout.GetLocalizedName() : null))
                .ForMember(x => x.PropertyType, x => x.MapFrom(li => li.PropertyType != null ? li.PropertyType.GetLocalizedName() : null))
                .ForMember(x => x.ImageUrls, x => x.MapFrom(li => li.Images.OrderBy(i => i.SortOrder).Select(i => i.Url).ToList()));
        }
    }
}
