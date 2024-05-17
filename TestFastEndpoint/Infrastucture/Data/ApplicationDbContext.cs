using Microsoft.EntityFrameworkCore;
using TestFastEndpoint.Entities;

namespace TestFastEndpoint.Infrastucture.Data
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FastEndpoint;Trusted_Connection=True");
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Personaggio> Personaggi => Set<Personaggio>();
    }
}
