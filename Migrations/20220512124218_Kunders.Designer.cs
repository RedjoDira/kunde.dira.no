// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using kunde.dira.no.Data.EF;

#nullable disable

namespace kunde.dira.no.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20220512124218_Kunders")]
    partial class Kunders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("kunde.dira.no.Models.Kunder", b =>
                {
                    b.Property<long>("OrgNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("OrgNr"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KontaktPLed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KontaktPTek")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KontaktPØk")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostNrSted")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TripleTID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OrgNr");

                    b.ToTable("Kunders");
                });
#pragma warning restore 612, 618
        }
    }
}
