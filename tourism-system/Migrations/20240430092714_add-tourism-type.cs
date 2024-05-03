using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class addtourismtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TourismType",
                table: "tourismLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FavoritType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TourismType",
                table: "tourismLocations");

            migrationBuilder.DropColumn(
                name: "FavoritType",
                table: "AspNetUsers");
        }
    }
}
