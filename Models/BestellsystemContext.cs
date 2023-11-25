using Microsoft.EntityFrameworkCore;

namespace Bestellsystem_API.Models
{
    public class BestellsystemContext : DbContext
    {
        public BestellsystemContext(DbContextOptions<BestellsystemContext> options)
        : base(options) { }
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add relation declarations
            base.OnModelCreating(modelBuilder);
        }
    }
}
