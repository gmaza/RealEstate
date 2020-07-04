using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PropertyLayoutConfiguration : MultiLangEntityConfiguration<PropertyLayout>
    {
        public override void Configure(EntityTypeBuilder<PropertyLayout> builder)
        {
            base.Configure(builder);
        }
    }
}
