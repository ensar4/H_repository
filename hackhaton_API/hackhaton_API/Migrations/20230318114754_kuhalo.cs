using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackhaton_API.Migrations
{
    /// <inheritdoc />
    public partial class kuhalo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kuhalo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StanjeStruje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VrijemeGasenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VrijemePaljenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HomeId = table.Column<int>(type: "int", nullable: false),
                    TipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kuhalo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kuhalo_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kuhalo_Tip_TipId",
                        column: x => x.TipId,
                        principalTable: "Tip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kuhalo_HomeId",
                table: "Kuhalo",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kuhalo_TipId",
                table: "Kuhalo",
                column: "TipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kuhalo");
        }
    }
}
