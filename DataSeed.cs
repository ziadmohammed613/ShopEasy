using System;
using ShopEasy.Data;
using System.Text.Json;
using ShopEasy.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopEasy
{
    public static class DataSeedClass
    {
        public static void DataSeed(this AppDbContext context , ModelBuilder modelBuilder)
        {
            // there's a problem with identity , so I can't seed data
            {
                var json = File.ReadAllText("./Models/JsonData/categories.json");
                var data = JsonSerializer.Deserialize<List<Category>>(json);
                modelBuilder.Entity<Category>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/customers.json");
                var data = JsonSerializer.Deserialize<List<Customer>>(json);
                modelBuilder.Entity<Customer>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/customerProfiles.json");
                var data = JsonSerializer.Deserialize<List<CustomerProfile>>(json);
                modelBuilder.Entity<CustomerProfile>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/tags.json");
                var data = JsonSerializer.Deserialize<List<Tag>>(json);
                modelBuilder.Entity<Tag>().HasData(data!);        
            }

            {
                var json = File.ReadAllText("./Models/JsonData/products.json");
                var data = JsonSerializer.Deserialize<List<Product>>(json);
                modelBuilder.Entity<Product>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/productTags.json");
                var data = JsonSerializer.Deserialize<List<ProductTag>>(json);
                modelBuilder.Entity<ProductTag>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/orders.json");
                var data = JsonSerializer.Deserialize<List<Order>>(json);
                modelBuilder.Entity<Order>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/orderItems.json");
                var data = JsonSerializer.Deserialize<List<OrderItem>>(json);
                modelBuilder.Entity<OrderItem>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/payments.json");
                var data = JsonSerializer.Deserialize<List<Payment>>(json);
                modelBuilder.Entity<Payment>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/reviews.json");
                var data = JsonSerializer.Deserialize<List<Review>>(json);
                modelBuilder.Entity<Review>().HasData(data!);
            }

            {
                var json = File.ReadAllText("./Models/JsonData/discounts.json");
                var data = JsonSerializer.Deserialize<List<Discount>>(json);
                modelBuilder.Entity<Discount>().HasData(data!);
            }
        }
        
    }
}