using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class FavoriteListingConfiguration : IEntityTypeConfiguration<FavoriteListing>
    {
        public void Configure(EntityTypeBuilder<FavoriteListing> builder)
        {
            builder.HasKey(x => new { x.ApplicationUserId, x.ListingId });

            builder.HasOne(x => x.ApplicationUser)
                .WithMany(u => u.FavoriteListings)
                .HasForeignKey(x => x.ApplicationUserId);

            builder.HasOne(x => x.Listing)
                .WithMany(li => li.FavoriteListings)
                .HasForeignKey(x => x.ListingId);
        }
    }
}
