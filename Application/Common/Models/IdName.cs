using Application.Common.Mappings;
using AutoMapper;
using Domain.Common;

namespace Application.Common.Models
{
    public class IdName : IMapFrom<MultiLangNameEntity>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<MultiLangNameEntity, IdName>()
                .ForMember(x => x.Name, x => x.MapFrom(ml => ml.GetLocalizedName()));
        }
    }
}
