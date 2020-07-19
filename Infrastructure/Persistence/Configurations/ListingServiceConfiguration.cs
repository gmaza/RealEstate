using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ListingServiceConfiguration : IEntityTypeConfiguration<ListingService>
    {
        public void Configure(EntityTypeBuilder<ListingService> builder)
        {
            builder.HasOne(x => x.Listing)
                .WithMany(li => li.ListingServices)
                .HasForeignKey(x => x.ListingId);

            builder.HasOne(x => x.Service)
                .WithMany(s => s.ListingServices)
                .HasForeignKey(x => x.ServiceId);
        }
    }
}
