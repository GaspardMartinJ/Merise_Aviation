using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_merise.Migrations
{
    /// <inheritdoc />
    public partial class Merise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeroports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_aero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeroports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Compagnie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_emp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom_emp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Est_chef_cabine = table.Column<bool>(type: "bit", nullable: true),
                    Est_commandant = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jour_depart = table.Column<DateOnly>(type: "date", nullable: false),
                    Heure_depart = table.Column<TimeOnly>(type: "time", nullable: false),
                    Nb_places_vendues = table.Column<int>(type: "int", nullable: false),
                    AvionId = table.Column<int>(type: "int", nullable: false),
                    Code_aero_dep = table.Column<int>(type: "int", nullable: false),
                    Code_aero_arr = table.Column<int>(type: "int", nullable: false),
                    AeroportId = table.Column<int>(type: "int", nullable: true),
                    AeroportId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vols_Aeroports_AeroportId",
                        column: x => x.AeroportId,
                        principalTable: "Aeroports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vols_Aeroports_AeroportId1",
                        column: x => x.AeroportId1,
                        principalTable: "Aeroports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vols_Avions_AvionId",
                        column: x => x.AvionId,
                        principalTable: "Avions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipageVol",
                columns: table => new
                {
                    PersonnelId = table.Column<int>(type: "int", nullable: false),
                    VolsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipageVol", x => new { x.PersonnelId, x.VolsId });
                    table.ForeignKey(
                        name: "FK_EquipageVol_Equipages_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Equipages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipageVol_Vols_VolsId",
                        column: x => x.VolsId,
                        principalTable: "Vols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_place = table.Column<int>(type: "int", nullable: false),
                    VolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passagers_Vols_VolId",
                        column: x => x.VolId,
                        principalTable: "Vols",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipageVol_VolsId",
                table: "EquipageVol",
                column: "VolsId");

            migrationBuilder.CreateIndex(
                name: "IX_Passagers_VolId",
                table: "Passagers",
                column: "VolId");

            migrationBuilder.CreateIndex(
                name: "IX_Vols_AeroportId",
                table: "Vols",
                column: "AeroportId");

            migrationBuilder.CreateIndex(
                name: "IX_Vols_AeroportId1",
                table: "Vols",
                column: "AeroportId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vols_AvionId",
                table: "Vols",
                column: "AvionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipageVol");

            migrationBuilder.DropTable(
                name: "Passagers");

            migrationBuilder.DropTable(
                name: "Equipages");

            migrationBuilder.DropTable(
                name: "Vols");

            migrationBuilder.DropTable(
                name: "Aeroports");

            migrationBuilder.DropTable(
                name: "Avions");
        }
    }
}
