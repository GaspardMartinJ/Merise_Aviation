using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_merise.Migrations
{
    /// <inheritdoc />
    public partial class Reservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagers_Vols_VolId",
                table: "Passagers");

            migrationBuilder.DropIndex(
                name: "IX_Passagers_VolId",
                table: "Passagers");

            migrationBuilder.DropColumn(
                name: "VolId",
                table: "Passagers");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    PassagerId = table.Column<int>(type: "int", nullable: false),
                    VolId = table.Column<int>(type: "int", nullable: false),
                    DateReservation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.PassagerId, x.VolId });
                    table.ForeignKey(
                        name: "FK_Reservations_Passagers_PassagerId",
                        column: x => x.PassagerId,
                        principalTable: "Passagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Vols_VolId",
                        column: x => x.VolId,
                        principalTable: "Vols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VolId",
                table: "Reservations",
                column: "VolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "VolId",
                table: "Passagers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passagers_VolId",
                table: "Passagers",
                column: "VolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagers_Vols_VolId",
                table: "Passagers",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "Id");
        }
    }
}
