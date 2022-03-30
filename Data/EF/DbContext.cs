using kunde.dira.no.Models;
using Microsoft.EntityFrameworkCore;

namespace kunde.dira.no.Data.EF
{
    public class PostgresContext : DbContext {


        public PostgresContext(DbContextOptions<PostgresContext> options):

    base(options){  
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    base.OnModelCreating(modelBuilder);
    }

        public DbSet<Kunder> Kunders { get; set; }



}
}
