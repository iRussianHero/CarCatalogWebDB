using Microsoft.EntityFrameworkCore;

namespace CarCatalogWebDB.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarTable> CarTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
