using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ShopEasy.Data.Configurations;
using ShopEasy.Models;

namespace ShopEasy.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string appsettings = File.ReadAllText("./Data/appsettings.json");
            string connectionString = JsonSerializer.Deserialize<Dictionary<string,string>>(appsettings)!["ConnectionString"];

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("DiscountSeq", schema: "shop").StartsAt(1000).IncrementsBy(1);
            
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountConfiguration());

            this.DataSeed(modelBuilder);
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