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
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Korisnik",
                newName: "Prezime");

            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "Prezime",
                table: "Korisnik",
                newName: "Password");
        }
    }
}
