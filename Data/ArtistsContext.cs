using Microsoft.EntityFrameworkCore;
using ModelConfigurations.Entities;

namespace ModelConfigurations.Data
{
    public partial class ArtistsContext : DbContext
    {
        public ArtistsContext() { }

        public ArtistsContext(DbContextOptions<ArtistsContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<SalesOutlet> SalesOutlets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("data source=output/Artists.db");
            }
        }
    }
}














