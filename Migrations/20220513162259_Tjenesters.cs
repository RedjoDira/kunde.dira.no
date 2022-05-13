using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kunde.dira.no.Migrations
{
    public partial class Tjenesters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tjenester",
                table: "Tjenester");

            migrationBuilder.RenameTable(
                name: "Tjenester",
                newName: "Tjenesters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tjenesters",
                table: "Tjenesters",
                column: "TjenesterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tjenesters",
                table: "Tjenesters");

            migrationBuilder.RenameTable(
                name: "Tjenesters",
                newName: "Tjenester");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tjenester",
                table: "Tjenester",
                column: "TjenesterId");
        }
    }
}
