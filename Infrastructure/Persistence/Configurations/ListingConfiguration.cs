using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ListingConfiguration : IEntityTypeConfiguration<Listing>
    {
        public void Configure(EntityTypeBuilder<Listing> builder)
        {
            builder.HasKey(li => li.Id);

            builder.HasOne(li => li.OfferType)
                .WithMany(o => o.Listings)
                .HasForeignKey(li => li.OfferTypeId);

            builder.HasOne(li => li.PropertyType)
                .WithMany(pt => pt.Listings)
                .HasForeignKey(li => li.PropertyTypeId);

            builder.HasOne(li => li.PropertyLayout)
                .WithMany(pl => pl.Listings)
                .HasForeignKey(li => li.PropertyLayoutId);

            builder.HasOne(li => li.BuildingType)
                .WithMany(bt => bt.Listings)
                .HasForeignKey(li => li.BuildingTypeId);

            builder.HasOne(li => li.OwnershipType)
                .WithMany(ot => ot.Listings)
                .HasForeignKey(li => li.OwnershipTypeId);

            builder.HasOne(li => li.PropertyCondition)
                .WithMany(ot => ot.Listings)
                .HasForeignKey(li => li.PropertyConditionId);

            builder.HasMany(li => li.Images)
                .WithOne(img => img.Listing)
                .HasForeignKey(img => img.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(li => li.LandType)
                .WithMany(lt => lt.Listings)
                .HasForeignKey(li => li.LandTypeId);
        }
    }
}
