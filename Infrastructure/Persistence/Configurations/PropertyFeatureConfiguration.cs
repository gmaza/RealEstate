using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PropertyFeatureConfiguration : MultiLangEntityConfiguration<PropertyFeature>
    {
        public override void Configure(EntityTypeBuilder<PropertyFeature> builder)
        {
            base.Configure(builder);
        }
    }
}
