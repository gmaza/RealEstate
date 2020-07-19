using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ServiceConfiguration : MultiLangEntityConfiguration<Service>
    {
        public override void Configure(EntityTypeBuilder<Service> builder)
        {
            base.Configure(builder);
        }
    }
}
