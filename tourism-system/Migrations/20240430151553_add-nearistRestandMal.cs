using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class addnearistRestandMal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NearestHospital_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestHospital_Longitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestPharmacy_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestPharmacy_Longitude",
                table: "tourismLocations");

            migrationBuilder.RenameColumn(
                name: "NearestPharmacy_Description",
                table: "tourismLocations",
                newName: "NearestRestourant");

            migrationBuilder.RenameColumn(
                name: "NearestHospital_Description",
                table: "tourismLocations",
                newName: "NearestPharmacy");

            migrationBuilder.AddColumn<string>(
                name: "NearestHospital",
                table: "tourismLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NearestMall",
                table: "tourismLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NearestHospital",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestMall",
                table: "tourismLocations");

            migrationBuilder.RenameColumn(
                name: "NearestRestourant",
                table: "tourismLocations",
                newName: "NearestPharmacy_Description");

            migrationBuilder.RenameColumn(
                name: "NearestPharmacy",
                table: "tourismLocations",
                newName: "NearestHospital_Description");

            migrationBuilder.AddColumn<double>(
                name: "NearestHospital_Latitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NearestHospital_Longitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NearestPharmacy_Latitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NearestPharmacy_Longitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
