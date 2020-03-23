using Microsoft.EntityFrameworkCore;

namespace Laborator4.Model
{
    internal class ModelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=XPS-9560\\SQLEXPRESS; Database = EFCore2020; Trusted_Connection = True");
        //ChangeTracker.LazyLoadingEnabled = false;
 }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
            .HasMany<Order>(o => o.Orders)
            .WithOne(c => c.Client);

            modelBuilder.Entity<OrderDetails>()
            .HasOne<Order>(od => od.Order)
            .WithMany(o => o.OrderDetails);
            modelBuilder.Entity<Product>()
            .HasMany<OrderDetails>(p => p.OrderDetails)
            .WithOne(od => od.Product);
        }
    }

}
