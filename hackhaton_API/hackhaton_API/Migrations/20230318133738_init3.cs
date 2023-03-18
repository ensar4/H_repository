using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackhaton_API.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeId",
                table: "RobotskiUsisivac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "RobotskiUsisivac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RobotskiUsisivac_HomeId",
                table: "RobotskiUsisivac",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_RobotskiUsisivac_TipId",
                table: "RobotskiUsisivac",
                column: "TipId");

            migrationBuilder.AddForeignKey(
                name: "FK_RobotskiUsisivac_Home_HomeId",
                table: "RobotskiUsisivac",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RobotskiUsisivac_Tip_TipId",
                table: "RobotskiUsisivac",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RobotskiUsisivac_Home_HomeId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropForeignKey(
                name: "FK_RobotskiUsisivac_Tip_TipId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropIndex(
                name: "IX_RobotskiUsisivac_HomeId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropIndex(
                name: "IX_RobotskiUsisivac_TipId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "RobotskiUsisivac");
        }
    }
}
