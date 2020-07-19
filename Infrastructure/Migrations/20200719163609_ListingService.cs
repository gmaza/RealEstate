using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ListingService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "ApplicationUsers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    NameRU = table.Column<string>(nullable: true),
                    NameCZ = table.Column<string>(nullable: true),
                    CostPerDay = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListingServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: true),
                    ListingId = table.Column<long>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListingServices_Listings_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListingServices_ListingId",
                table: "ListingServices",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_ListingServices_ServiceId",
                table: "ListingServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListingServices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "ApplicationUsers");
        }
    }
}
