using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ShopEasy.Models;

namespace ShopEasy.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string appsettings = File.ReadAllText("./appsettings.json");
            string connectionString = JsonSerializer.Deserialize<Dictionary<string,string>>(appsettings)["ConnectionString"];
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("DiscountSeq", schema: "shop").StartsAt(1000).IncrementsBy(1);
        }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<CustomerProfile> CustomerProfiles { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderItem> OrderItems { set; get; }
        public DbSet<Payment> Payments { set; get; }
        public DbSet<Review> Reviews { set; get; }
        public DbSet<Discount> Discounts { set; get; }
    }
}