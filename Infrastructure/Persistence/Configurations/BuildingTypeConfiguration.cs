using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class BuildingTypeConfiguration : MultiLangEntityConfiguration<BuildingType>
    {
        public override void Configure(EntityTypeBuilder<BuildingType> builder)
        {
            base.Configure(builder);
        }
    }
}
