using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class LandTypeConfiguration : MultiLangEntityConfiguration<LandType>
    {
        public override void Configure(EntityTypeBuilder<LandType> builder)
        {
            base.Configure(builder);
        }
    }
}
