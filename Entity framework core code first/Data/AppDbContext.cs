using Microsoft.EntityFrameworkCore;
using EFCoreExample.Models;

namespace EFCoreExample.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=MyECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
