using JewelryManagementApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JewelryManagementApp.Data
{
    public class JewelryManagementDb : IdentityDbContext<User>
    {
        public JewelryManagementDb(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Shop -> Categories
            modelBuilder.Entity<Category>()
                .HasOne(c => c.Shop)
                .WithMany(s => s.Categories)
                .HasForeignKey(c => c.ShopId)
                .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete here

            // Category -> Products
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete here

            // Shop -> Products
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Shop)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.ShopId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete here

            // Shop -> Users
            modelBuilder.Entity<User>()
                .HasOne(u => u.Shop)
                .WithMany(s => s.Users)
                .HasForeignKey(u => u.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            // User -> Orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Shop -> Orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Shop)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShopId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete here

            // Order -> OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete for OrderId

            // Product -> OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete for ProductId

            // Specify precision for decimal properties
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.UnitPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);
        }
        public DbSet<JewelryManagementApp.Models.Shop> Shop { get; set; } = default!;
        public DbSet<JewelryManagementApp.Models.Category> Category { get; set; } = default!;
        public DbSet<JewelryManagementApp.Models.User> User { get; set; } = default!;
        public DbSet<JewelryManagementApp.Models.Order> Order { get; set; } = default!;
        public DbSet<JewelryManagementApp.Models.Product> Product { get; set; } = default!;
        public DbSet<JewelryManagementApp.Models.OrderDetail> OrderDetail { get; set; } = default!;


    }
}
