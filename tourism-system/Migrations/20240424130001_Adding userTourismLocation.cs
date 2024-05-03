using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class AddinguserTourismLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTourismLocation_AspNetUsers_IdentityUserId",
                table: "UserTourismLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTourismLocation_tourismLocations_TourismLocationId",
                table: "UserTourismLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTourismLocation",
                table: "UserTourismLocation");

            migrationBuilder.RenameTable(
                name: "UserTourismLocation",
                newName: "userTourismLocations");

            migrationBuilder.RenameIndex(
                name: "IX_UserTourismLocation_TourismLocationId",
                table: "userTourismLocations",
                newName: "IX_userTourismLocations_TourismLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTourismLocation_IdentityUserId",
                table: "userTourismLocations",
                newName: "IX_userTourismLocations_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userTourismLocations",
                table: "userTourismLocations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userTourismLocations_AspNetUsers_IdentityUserId",
                table: "userTourismLocations",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userTourismLocations_tourismLocations_TourismLocationId",
                table: "userTourismLocations",
                column: "TourismLocationId",
                principalTable: "tourismLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userTourismLocations_AspNetUsers_IdentityUserId",
                table: "userTourismLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_userTourismLocations_tourismLocations_TourismLocationId",
                table: "userTourismLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userTourismLocations",
                table: "userTourismLocations");

            migrationBuilder.RenameTable(
                name: "userTourismLocations",
                newName: "UserTourismLocation");

            migrationBuilder.RenameIndex(
                name: "IX_userTourismLocations_TourismLocationId",
                table: "UserTourismLocation",
                newName: "IX_UserTourismLocation_TourismLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_userTourismLocations_IdentityUserId",
                table: "UserTourismLocation",
                newName: "IX_UserTourismLocation_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTourismLocation",
                table: "UserTourismLocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTourismLocation_AspNetUsers_IdentityUserId",
                table: "UserTourismLocation",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTourismLocation_tourismLocations_TourismLocationId",
                table: "UserTourismLocation",
                column: "TourismLocationId",
                principalTable: "tourismLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
