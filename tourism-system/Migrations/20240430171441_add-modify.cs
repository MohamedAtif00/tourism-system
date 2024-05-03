using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class addmodify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NearestRestourant",
                table: "tourismLocations",
                newName: "NearestRestourant_Description");

            migrationBuilder.RenameColumn(
                name: "NearestPharmacy",
                table: "tourismLocations",
                newName: "NearestPharmacy_Description");

            migrationBuilder.RenameColumn(
                name: "NearestMall",
                table: "tourismLocations",
                newName: "NearestMall_Description");

            migrationBuilder.RenameColumn(
                name: "NearestHospital",
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
                name: "NearestMall_Latitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NearestMall_Longitude",
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

            migrationBuilder.AddColumn<double>(
                name: "NearestRestourant_Latitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NearestRestourant_Longitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NearestHospital_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestHospital_Longitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestMall_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestMall_Longitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestPharmacy_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestPharmacy_Longitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestRestourant_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestRestourant_Longitude",
                table: "tourismLocations");

            migrationBuilder.RenameColumn(
                name: "NearestRestourant_Description",
                table: "tourismLocations",
                newName: "NearestRestourant");

            migrationBuilder.RenameColumn(
                name: "NearestPharmacy_Description",
                table: "tourismLocations",
                newName: "NearestPharmacy");

            migrationBuilder.RenameColumn(
                name: "NearestMall_Description",
                table: "tourismLocations",
                newName: "NearestMall");

            migrationBuilder.RenameColumn(
                name: "NearestHospital_Description",
                table: "tourismLocations",
                newName: "NearestHospital");
        }
    }
}
