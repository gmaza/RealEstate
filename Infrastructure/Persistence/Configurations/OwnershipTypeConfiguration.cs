using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class OwnershipTypeConfiguration : MultiLangEntityConfiguration<OwnershipType>
    {
        public override void Configure(EntityTypeBuilder<OwnershipType> builder)
        {
            base.Configure(builder);
        }
    }
}
