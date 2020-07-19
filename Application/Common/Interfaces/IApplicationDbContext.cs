using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Listing> Listings { get; set; }
        DbSet<ListingImage> ListingImages { get; set; }
        DbSet<BuildingType> BuildingTypes { get; set; }
        DbSet<OfferType> OfferTypes { get; set; }
        DbSet<PropertyFeature> PropertyFeatures { get; set; }
        DbSet<PropertyLayout> PropertyLayouts { get; set; }
        DbSet<PropertyType> PropertyTypes { get; set; }
        DbSet<OwnershipType> OwnershipTypes { get; set; }
        DbSet<PropertyCondition> PropertyConditions { get; set; }
        DbSet<LandType> LandTypes { get; set; }
        DbSet<Furnishing> Furnishings { get; set; }
        DbSet<EnergyCertificate> EnergyCertificates { get; set; }
        DbSet<FavoriteListing> FavoriteListings { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<ListingService> ListingServices { get; set; }
        DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
