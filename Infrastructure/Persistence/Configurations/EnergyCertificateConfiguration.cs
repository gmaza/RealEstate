using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class EnergyCertificateConfiguration : MultiLangEntityConfiguration<EnergyCertificate>
    {
        public override void Configure(EntityTypeBuilder<EnergyCertificate> builder)
        {
            base.Configure(builder);
        }
    }
}
