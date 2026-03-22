using System;
using ShopEasy.Data;
using System.Text.Json;
using ShopEasy.Models;

namespace ShopEasy
{
    public static class DataSeedClass
    {
        public static void DataSeed(this AppDbContext context)
        {
            // there's a problem with identity , so I can't seed data
            if (!context.Categories.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/categories.json");
                var data = JsonSerializer.Deserialize<List<Category>>(json);
                context.Categories.AddRange(data!);
            }

            if (!context.Customers.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/customers.json");
                var data = JsonSerializer.Deserialize<List<Customer>>(json);
                context.Customers.AddRange(data!);
            }

            if (!context.CustomerProfiles.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/customerProfiles.json");
                var data = JsonSerializer.Deserialize<List<CustomerProfile>>(json);
                context.CustomerProfiles.AddRange(data!);
            }

            if (!context.Tags.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/tags.json");
                var data = JsonSerializer.Deserialize<List<Tag>>(json);
                context.Tags.AddRange(data!);
            }

            if (!context.Products.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/products.json");
                var data = JsonSerializer.Deserialize<List<Product>>(json);
                context.Products.AddRange(data!);
            }

            if (!context.ProductTags.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/productTags.json");
                var data = JsonSerializer.Deserialize<List<ProductTag>>(json);
                context.ProductTags.AddRange(data!);
            }

            if (!context.Orders.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/orders.json");
                var data = JsonSerializer.Deserialize<List<Order>>(json);
                context.Orders.AddRange(data!);
            }

            if (!context.OrderItems.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/orderItems.json");
                var data = JsonSerializer.Deserialize<List<OrderItem>>(json);
                context.OrderItems.AddRange(data!);
            }

            if (!context.Payments.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/payments.json");
                var data = JsonSerializer.Deserialize<List<Payment>>(json);
                context.Payments.AddRange(data!);
            }

            if (!context.Reviews.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/reviews.json");
                var data = JsonSerializer.Deserialize<List<Review>>(json);
                context.Reviews.AddRange(data!);
            }

            if (!context.Discounts.Any())
            {
                var json = File.ReadAllText("./Models/JsonData/discounts.json");
                var data = JsonSerializer.Deserialize<List<Discount>>(json);
                context.Discounts.AddRange(data!);
            }
        }
        
    }
}