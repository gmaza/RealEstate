using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class FurnishingConfiguration : MultiLangEntityConfiguration<Furnishing>
    {
        public override void Configure(EntityTypeBuilder<Furnishing> builder)
        {
            base.Configure(builder);
        }
    }
}
