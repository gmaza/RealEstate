using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(x => x.Listings)
                .WithOne(li => li.Owner)
                .HasForeignKey(li => li.OwnerId);

            builder.HasMany(x => x.PaymentTransactions)
                .WithOne(p => p.ApplicationUser)
                .HasForeignKey(p => p.ApplicationUserId);
        }
    }
}
