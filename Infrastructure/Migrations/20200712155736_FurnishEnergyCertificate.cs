using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FurnishEnergyCertificate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnergyCertificateId",
                table: "Listings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FurnishingId",
                table: "Listings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EnergyCertificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    NameRU = table.Column<string>(nullable: true),
                    NameCZ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyCertificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Furnishings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NameEN = table.Column<string>(nullable: true),
                    NameRU = table.Column<string>(nullable: true),
                    NameCZ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnishings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Listings_EnergyCertificateId",
                table: "Listings",
                column: "EnergyCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_FurnishingId",
                table: "Listings",
                column: "FurnishingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_EnergyCertificates_EnergyCertificateId",
                table: "Listings",
                column: "EnergyCertificateId",
                principalTable: "EnergyCertificates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_Furnishings_FurnishingId",
                table: "Listings",
                column: "FurnishingId",
                principalTable: "Furnishings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_EnergyCertificates_EnergyCertificateId",
                table: "Listings");

            migrationBuilder.DropForeignKey(
                name: "FK_Listings_Furnishings_FurnishingId",
                table: "Listings");

            migrationBuilder.DropTable(
                name: "EnergyCertificates");

            migrationBuilder.DropTable(
                name: "Furnishings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_EnergyCertificateId",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_FurnishingId",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "EnergyCertificateId",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "FurnishingId",
                table: "Listings");
        }
    }
}
