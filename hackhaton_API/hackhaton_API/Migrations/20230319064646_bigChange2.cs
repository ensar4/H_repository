using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackhaton_API.Migrations
{
    /// <inheritdoc />
    public partial class bigChange2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klima_Tip_TipId",
                table: "Klima");

            migrationBuilder.DropForeignKey(
                name: "FK_Kuhalo_Tip_TipId",
                table: "Kuhalo");

            migrationBuilder.DropForeignKey(
                name: "FK_MotionSensor_Tip_TipId",
                table: "MotionSensor");

            migrationBuilder.DropForeignKey(
                name: "FK_Pegla_Tip_TipId",
                table: "Pegla");

            migrationBuilder.DropForeignKey(
                name: "FK_ProciscivacZraka_Tip_TipId",
                table: "ProciscivacZraka");

            migrationBuilder.DropForeignKey(
                name: "FK_Prozori_Tip_TipId",
                table: "Prozori");

            migrationBuilder.DropForeignKey(
                name: "FK_RobotskiUsisivac_Tip_TipId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropForeignKey(
                name: "FK_SenzorDima_Tip_TipId",
                table: "SenzorDima");

            migrationBuilder.DropForeignKey(
                name: "FK_Tlakomjer_Tip_TipId",
                table: "Tlakomjer");

            migrationBuilder.DropForeignKey(
                name: "FK_Vrata_Tip_TipId",
                table: "Vrata");

            migrationBuilder.DropTable(
                name: "Tip");

            migrationBuilder.DropIndex(
                name: "IX_Vrata_TipId",
                table: "Vrata");

            migrationBuilder.DropIndex(
                name: "IX_Tlakomjer_TipId",
                table: "Tlakomjer");

            migrationBuilder.DropIndex(
                name: "IX_SenzorDima_TipId",
                table: "SenzorDima");

            migrationBuilder.DropIndex(
                name: "IX_RobotskiUsisivac_TipId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropIndex(
                name: "IX_Prozori_TipId",
                table: "Prozori");

            migrationBuilder.DropIndex(
                name: "IX_ProciscivacZraka_TipId",
                table: "ProciscivacZraka");

            migrationBuilder.DropIndex(
                name: "IX_Pegla_TipId",
                table: "Pegla");

            migrationBuilder.DropIndex(
                name: "IX_MotionSensor_TipId",
                table: "MotionSensor");

            migrationBuilder.DropIndex(
                name: "IX_Kuhalo_TipId",
                table: "Kuhalo");

            migrationBuilder.DropIndex(
                name: "IX_Klima_TipId",
                table: "Klima");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Vrata");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Tlakomjer");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "SenzorDima");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "RobotskiUsisivac");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Prozori");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "ProciscivacZraka");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Pegla");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "MotionSensor");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Kuhalo");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Klima");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Vrata",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Tlakomjer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "SenzorDima",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "RobotskiUsisivac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Prozori",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "ProciscivacZraka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Pegla",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "MotionSensor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Kuhalo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Klima",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Vrata_TipId",
                table: "Vrata",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Tlakomjer_TipId",
                table: "Tlakomjer",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_SenzorDima_TipId",
                table: "SenzorDima",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_RobotskiUsisivac_TipId",
                table: "RobotskiUsisivac",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Prozori_TipId",
                table: "Prozori",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_ProciscivacZraka_TipId",
                table: "ProciscivacZraka",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Pegla_TipId",
                table: "Pegla",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_MotionSensor_TipId",
                table: "MotionSensor",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Kuhalo_TipId",
                table: "Kuhalo",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_Klima_TipId",
                table: "Klima",
                column: "TipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Klima_Tip_TipId",
                table: "Klima",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kuhalo_Tip_TipId",
                table: "Kuhalo",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotionSensor_Tip_TipId",
                table: "MotionSensor",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pegla_Tip_TipId",
                table: "Pegla",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProciscivacZraka_Tip_TipId",
                table: "ProciscivacZraka",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prozori_Tip_TipId",
                table: "Prozori",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RobotskiUsisivac_Tip_TipId",
                table: "RobotskiUsisivac",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SenzorDima_Tip_TipId",
                table: "SenzorDima",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tlakomjer_Tip_TipId",
                table: "Tlakomjer",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vrata_Tip_TipId",
                table: "Vrata",
                column: "TipId",
                principalTable: "Tip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
