using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tourism_system.Migrations
{
    /// <inheritdoc />
    public partial class Addinguser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTourismLocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourismLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitingNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTourismLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTourismLocation_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTourismLocation_tourismLocations_TourismLocationId",
                        column: x => x.TourismLocationId,
                        principalTable: "tourismLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTourismLocation_IdentityUserId",
                table: "UserTourismLocation",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTourismLocation_TourismLocationId",
                table: "UserTourismLocation",
                column: "TourismLocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTourismLocation");
        }
    }
}
