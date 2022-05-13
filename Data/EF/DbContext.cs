using kunde.dira.no.Models;
using Microsoft.EntityFrameworkCore;

namespace kunde.dira.no.Data.EF
{
    public class PostgresContext : DbContext
    {


        public PostgresContext(DbContextOptions<PostgresContext> options):
        base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Kunder> Kunders { get; set; }
        public DbSet<Kontakter> Kontakers { get; set; }
        public DbSet<Tjenester> Tjenesters { get; set; }



    }
}
