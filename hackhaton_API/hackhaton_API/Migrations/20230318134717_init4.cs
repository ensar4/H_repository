using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackhaton_API.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tlakomjer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtkucajiSrca = table.Column<int>(type: "int", nullable: false),
                    Tlak = table.Column<int>(type: "int", nullable: false),
                    HomeId = table.Column<int>(type: "int", nullable: false),
                    TipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tlakomjer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tlakomjer_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tlakomjer_Tip_TipId",
                        column: x => x.TipId,
                        principalTable: "Tip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tlakomjer_HomeId",
                table: "Tlakomjer",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tlakomjer_TipId",
                table: "Tlakomjer",
                column: "TipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tlakomjer");
        }
    }
}
