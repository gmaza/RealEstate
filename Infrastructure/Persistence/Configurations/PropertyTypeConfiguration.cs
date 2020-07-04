using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PropertyTypeConfiguration : MultiLangEntityConfiguration<PropertyType>
    {
        public override void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            base.Configure(builder);
        }
    }
}
