using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ListingFeatureConfiguration : IEntityTypeConfiguration<ListingFeature>
    {
        public void Configure(EntityTypeBuilder<ListingFeature> builder)
        {
            builder.HasKey(f => new { f.ListingId, f.PropertyFeatureId });

            builder.HasOne(f => f.Listing)
                .WithMany(li => li.Features)
                .HasForeignKey(f => f.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(f => f.PropertyFeature)
                .WithMany(pf => pf.ListingFeatures)
                .HasForeignKey(f => f.PropertyFeatureId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
