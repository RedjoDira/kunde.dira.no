using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace kunde.dira.no.Migrations
{
    public partial class Kunders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunders",
                columns: table => new
                {
                    OrgNr = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    PostNrSted = table.Column<string>(type: "text", nullable: false),
                    KontaktPTek = table.Column<string>(type: "text", nullable: false),
                    KontaktPØk = table.Column<string>(type: "text", nullable: false),
                    KontaktPLed = table.Column<string>(type: "text", nullable: false),
                    TripleTID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunders", x => x.OrgNr);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunders");
        }
    }
}
