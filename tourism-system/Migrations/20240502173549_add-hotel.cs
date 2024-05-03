using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class addhotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "A_from",
                table: "tourismLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "A_to",
                table: "tourismLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "B_from",
                table: "tourismLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "B_to",
                table: "tourismLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "C_from",
                table: "tourismLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "C_to",
                table: "tourismLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NearestHotel_Description",
                table: "tourismLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "NearestHotel_Latitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NearestHotel_Longitude",
                table: "tourismLocations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "A_from",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "A_to",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "B_from",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "B_to",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "C_from",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "C_to",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestHotel_Description",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestHotel_Latitude",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "NearestHotel_Longitude",
                table: "tourismLocations");
        }
    }
}
