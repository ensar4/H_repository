using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackhaton_API.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeId",
                table: "ProciscivacZraka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "ProciscivacZraka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProciscivacZraka_HomeId",
                table: "ProciscivacZraka",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProciscivacZraka_TipId",
                table: "ProciscivacZraka",
                column: "TipId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProciscivacZraka_Home_HomeId",
                table: "ProciscivacZraka",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProciscivacZraka_Tip_TipId",
                table: "ProciscivacZraka",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProciscivacZraka_Home_HomeId",
                table: "ProciscivacZraka");

            migrationBuilder.DropForeignKey(
                name: "FK_ProciscivacZraka_Tip_TipId",
                table: "ProciscivacZraka");

            migrationBuilder.DropIndex(
                name: "IX_ProciscivacZraka_HomeId",
                table: "ProciscivacZraka");

            migrationBuilder.DropIndex(
                name: "IX_ProciscivacZraka_TipId",
                table: "ProciscivacZraka");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "ProciscivacZraka");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "ProciscivacZraka");
        }
    }
}
