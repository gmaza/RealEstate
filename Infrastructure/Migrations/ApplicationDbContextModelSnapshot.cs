﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<Guid>("IdentityUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("Domain.Entities.BuildingType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BuildingTypes");
                });

            modelBuilder.Entity("Domain.Entities.EnergyCertificate", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EnergyCertificates");
                });

            modelBuilder.Entity("Domain.Entities.Furnishing", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Furnishings");
                });

            modelBuilder.Entity("Domain.Entities.LandType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LandTypes");
                });

            modelBuilder.Entity("Domain.Entities.Listing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Area")
                        .HasColumnType("integer");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("BuildingTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<decimal?>("Deposit")
                        .HasColumnType("numeric");

                    b.Property<string>("DescriptionCZ")
                        .HasColumnType("text");

                    b.Property<string>("DescriptionEN")
                        .HasColumnType("text");

                    b.Property<string>("DescriptionRU")
                        .HasColumnType("text");

                    b.Property<int?>("EnergyCertificateId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Fees")
                        .HasColumnType("numeric");

                    b.Property<int?>("Floor")
                        .HasColumnType("integer");

                    b.Property<int?>("FurnishingId")
                        .HasColumnType("integer");

                    b.Property<int?>("LandTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<string>("Municipality")
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("OfferTypeId")
                        .HasColumnType("integer");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<int?>("OwnershipTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("PostCode")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int?>("PropertyConditionId")
                        .HasColumnType("integer");

                    b.Property<int?>("PropertyLayoutId")
                        .HasColumnType("integer");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("BuildingTypeId");

                    b.HasIndex("EnergyCertificateId");

                    b.HasIndex("FurnishingId");

                    b.HasIndex("LandTypeId");

                    b.HasIndex("OfferTypeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("OwnershipTypeId");

                    b.HasIndex("PropertyConditionId");

                    b.HasIndex("PropertyLayoutId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Listings");
                });

            modelBuilder.Entity("Domain.Entities.ListingFeature", b =>
                {
                    b.Property<long>("ListingId")
                        .HasColumnType("bigint");

                    b.Property<int>("PropertyFeatureId")
                        .HasColumnType("integer");

                    b.HasKey("ListingId", "PropertyFeatureId");

                    b.HasIndex("PropertyFeatureId");

                    b.ToTable("ListingFeature");
                });

            modelBuilder.Entity("Domain.Entities.ListingImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("ListingId")
                        .HasColumnType("bigint");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.ToTable("ListingImages");
                });

            modelBuilder.Entity("Domain.Entities.OfferType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OfferTypes");
                });

            modelBuilder.Entity("Domain.Entities.OwnershipType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OwnershipTypes");
                });

            modelBuilder.Entity("Domain.Entities.PropertyCondition", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PropertyConditions");
                });

            modelBuilder.Entity("Domain.Entities.PropertyFeature", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PropertyFeatures");
                });

            modelBuilder.Entity("Domain.Entities.PropertyLayout", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PropertyLayouts");
                });

            modelBuilder.Entity("Domain.Entities.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("NameCZ")
                        .HasColumnType("text");

                    b.Property<string>("NameEN")
                        .HasColumnType("text");

                    b.Property<string>("NameRU")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("Infrastructure.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Domain.Entities.Listing", b =>
                {
                    b.HasOne("Domain.Entities.BuildingType", "BuildingType")
                        .WithMany("Listings")
                        .HasForeignKey("BuildingTypeId");

                    b.HasOne("Domain.Entities.EnergyCertificate", "EnergyCertificate")
                        .WithMany("Listings")
                        .HasForeignKey("EnergyCertificateId");

                    b.HasOne("Domain.Entities.Furnishing", "Furnishing")
                        .WithMany("Listings")
                        .HasForeignKey("FurnishingId");

                    b.HasOne("Domain.Entities.LandType", "LandType")
                        .WithMany("Listings")
                        .HasForeignKey("LandTypeId");

                    b.HasOne("Domain.Entities.OfferType", "OfferType")
                        .WithMany("Listings")
                        .HasForeignKey("OfferTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ApplicationUser", "Owner")
                        .WithMany("Listings")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.OwnershipType", "OwnershipType")
                        .WithMany("Listings")
                        .HasForeignKey("OwnershipTypeId");

                    b.HasOne("Domain.Entities.PropertyCondition", "PropertyCondition")
                        .WithMany("Listings")
                        .HasForeignKey("PropertyConditionId");

                    b.HasOne("Domain.Entities.PropertyLayout", "PropertyLayout")
                        .WithMany("Listings")
                        .HasForeignKey("PropertyLayoutId");

                    b.HasOne("Domain.Entities.PropertyType", "PropertyType")
                        .WithMany("Listings")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ListingFeature", b =>
                {
                    b.HasOne("Domain.Entities.Listing", "Listing")
                        .WithMany("Features")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PropertyFeature", "PropertyFeature")
                        .WithMany("ListingFeatures")
                        .HasForeignKey("PropertyFeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ListingImage", b =>
                {
                    b.HasOne("Domain.Entities.Listing", "Listing")
                        .WithMany("Images")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
