using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PropertyConditionConfiguration : MultiLangEntityConfiguration<PropertyCondition>
    {
        public override void Configure(EntityTypeBuilder<PropertyCondition> builder)
        {
            base.Configure(builder);
        }
    }
}
