using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class add2modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userTourismLocations_AspNetUsers_IdentityUserId",
                table: "userTourismLocations");

            migrationBuilder.DropIndex(
                name: "IX_userTourismLocations_IdentityUserId",
                table: "userTourismLocations");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "userTourismLocations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdentityUserId",
                table: "userTourismLocations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_userTourismLocations_IdentityUserId",
                table: "userTourismLocations",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_userTourismLocations_AspNetUsers_IdentityUserId",
                table: "userTourismLocations",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
