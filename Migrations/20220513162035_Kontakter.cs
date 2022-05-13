using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace kunde.dira.no.Migrations
{
    public partial class Kontakter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kontakers",
                columns: table => new
                {
                    OrgNr = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Fornavn = table.Column<string>(type: "text", nullable: false),
                    Etternavn = table.Column<string>(type: "text", nullable: false),
                    Epost = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    TlfNum = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakers", x => x.OrgNr);
                });

            migrationBuilder.CreateTable(
                name: "Tjenester",
                columns: table => new
                {
                    TjenesterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TjenesterName = table.Column<string>(type: "text", nullable: false),
                    TjenesterType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tjenester", x => x.TjenesterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kontakers");

            migrationBuilder.DropTable(
                name: "Tjenester");
        }
    }
}
