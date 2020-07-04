using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class OfferTypeConfiguration : MultiLangEntityConfiguration<OfferType>
    {
        public override void Configure(EntityTypeBuilder<OfferType> builder)
        {
            base.Configure(builder);
        }
    }
}
