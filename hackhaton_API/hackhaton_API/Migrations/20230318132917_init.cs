using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackhaton_API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProciscivacZraka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stanje = table.Column<bool>(type: "bit", nullable: false),
                    VlaznostZraka = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProciscivacZraka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RobotskiUsisivac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stanje = table.Column<bool>(type: "bit", nullable: false),
                    VrijemePaljenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VrijemeGasenja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotskiUsisivac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik_Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik_Home", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnik_Home_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnik_Home_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stanje = table.Column<bool>(type: "bit", nullable: false),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    Mod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrzinaPuhanja = table.Column<int>(type: "int", nullable: false),
                    HomeId = table.Column<int>(type: "int", nullable: false),
                    TipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Klima_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Klima_Tip_TipId",
                        column: x => x.TipId,
                        principalTable: "Tip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotionSensor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokretDetektovan = table.Column<bool>(type: "bit", nullable: false),
                    OsobaPala = table.Column<bool>(type: "bit", nullable: false),
                    HomeId = table.Column<int>(type: "int", nullable: false),
                    TipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotionSensor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotionSensor_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotionSensor_Tip_TipId",
                        column: x => x.TipId,
                        principalTable: "Tip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klima_HomeId",
                table: "Klima",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Klima_TipId",
                table: "Klima",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Home_HomeId",
                table: "Korisnik_Home",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Home_KorisnikId",
                table: "Korisnik_Home",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_MotionSensor_HomeId",
                table: "MotionSensor",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_MotionSensor_TipId",
                table: "MotionSensor",
                column: "TipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klima");

            migrationBuilder.DropTable(
                name: "Korisnik_Home");

            migrationBuilder.DropTable(
                name: "MotionSensor");

            migrationBuilder.DropTable(
                name: "ProciscivacZraka");

            migrationBuilder.DropTable(
                name: "RobotskiUsisivac");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Home");

            migrationBuilder.DropTable(
                name: "Tip");
        }
    }
}
