using System;
using Microsoft.EntityFrameworkCore;
using ShopEasy.Data;
using ShopEasy.Models;

namespace ShopEasy
{
    public static class Program
    {
        public static void Main()
        {
            var context = new AppDbContext();
        }
        public static void Register(this AppDbContext context)
        {
            try
            {
                System.Console.WriteLine("Customer:");
                var customer = new Customer();
                System.Console.Write("FullName: ");
                customer.FullName = Console.ReadLine()!;
                System.Console.Write("Email: ");
                customer.Email = Console.ReadLine()!;
                System.Console.Write("PhoneNumber: ");
                customer.PhoneNumber = Console.ReadLine();

                System.Console.WriteLine("CustomerProfile:");
                var customerProfile = new CustomerProfile();
                customerProfile.Customer = customer;
                System.Console.Write("Address:");
                customerProfile.Address = Console.ReadLine();
                System.Console.Write("City:");
                customerProfile.City = Console.ReadLine();
                System.Console.Write("PostalCode:");
                customerProfile.PostalCode = Console.ReadLine();
                System.Console.Write("NationalId:");
                customerProfile.NationalId = Console.ReadLine();

                context.Customers.Add(customer);
                context.CustomerProfiles.Add(customerProfile);

                context.SaveChanges();

                System.Console.WriteLine("Customer Registerd Successfully!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Error! {e.Message}");
            }
        }
        public static void ViewCustomerProfile(this AppDbContext context)
        {
            try
            {
                System.Console.Write("CustomerId: ");
                int customerId = int.Parse(Console.ReadLine()!);

                var customerProfile = context.CustomerProfiles.Single(cp => cp.CustomerId == customerId);
                System.Console.WriteLine(customerProfile);
            }
            catch
            {
                System.Console.WriteLine("Couldn't find customer");
            }
            
        }
        public static void UpdataAddress(this AppDbContext context)
        {
            System.Console.Write("Id: ");
            int CpId = int.Parse(Console.ReadLine()!);
            var customerProfile = context.CustomerProfiles.SingleOrDefault(cp => cp.CustomerId == CpId);
            System.Console.Write("New Address: ");
            string newAddr = Console.ReadLine()!;
            
            if(customerProfile != null)
            {
                customerProfile.Address = newAddr;
                context.SaveChanges();
            }
            else
            {
                customerProfile = new CustomerProfile { Address =  newAddr};
            }

        }
        public static void ViewProducts(this AppDbContext context)
        {
            var products = context.Products.Include(p => p.Category)
                                            .Where(p => p.IsActive)
                                            .OrderBy(p => p.Price)
                                            .Join(context.Categories , p => p.CategoryId , c => c.CategoryId , (p, c) => new
                                            {
                                                ProductName = p.Name ,
                                                p.Price ,
                                                CategoryName = c.Name
                                            }).AsNoTracking();;
            foreach(var product in products)
            {
                System.Console.WriteLine(product);
            }
        }
        public static void SearchProduct(this AppDbContext context)
        {
            System.Console.Write("Search by 1.Category 2.Name :");
            int search = int.Parse(Console.ReadLine()!);
            if(search == 1)
            { // category
                System.Console.Write("Category Name: ");
                var products = context.Products.Include(p => p.Category)
                                        .Where(p => p.IsActive)
                                        .Where(p => p.Category.Name.Contains(Console.ReadLine()!))
                                        .AsNoTracking();
            }
            else if(search == 2)
            { // name
                Console.Write("Product Name: ");
                var products = context.Products.Where(p => p.IsActive)
                                        .Where(p => p.Name.Contains(Console.ReadLine()!))
                                        .AsNoTracking();
                foreach(var product in products)
                {
                    System.Console.WriteLine(product);
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Value");
            }
        }
        public static void ViewProductDetails(this AppDbContext context)
        {
            System.Console.Write("Product Id: ");
            int productId = int.Parse(Console.ReadLine()!);
            var productDetails = context.Products.Include(p => p.ProductTags)
                                                    .ThenInclude(pt => pt.Tag)
                                                    .Include(p => p.Reviews)
                                                    .Select(p => new
                                                    {
                                                        p.Name,
                                                        p.Price,
                                                        Tags = p.ProductTags.Select(pt => pt.Tag.Name).ToList(),
                                                        Reviews = p.Reviews.Select(r => new { r.Rating, r.Comment }).ToList()
                                                    });
            
            foreach(var product in productDetails)
            {
                System.Console.WriteLine($"Name: {product.Name} , Price: {product.Price}");
                System.Console.WriteLine("Tags:");
                foreach(var tag in product.Tags)
                {
                    System.Console.WriteLine($"- {tag}");
                }
                int totalReviews = product.Reviews.Count;
                System.Console.WriteLine($"Total Reviews: {totalReviews}");
                float averageRating = totalReviews > 0 ? (float)product.Reviews.Average(r => r.Rating) : 0;
                System.Console.WriteLine($"Average Rating: {averageRating}");
                System.Console.WriteLine("Reviews:");
                foreach(var review in product.Reviews)
                {
                    System.Console.WriteLine($"- Rating: {review.Rating} , Comment: {review.Comment}");
                }
            }
        }
        public static void TopFiveRatedProducts(this AppDbContext context)
        {
            var topProducts = context.Products.Include(p => p.Reviews)
                                                .Where(p => p.IsActive)
                                                .Select(p => new
                                                {
                                                    p.Name,
                                                    p.Price,
                                                    AverageRating = p.Reviews.Count > 0 ? (float)p.Reviews.Average(r => r.Rating) : 0
                                                })
                                                .OrderByDescending(p => p.AverageRating)
                                                .ThenBy(p => p.Name)
                                                .Take(5)
                                                .AsNoTracking();
            foreach(var product in topProducts)
            {
                System.Console.WriteLine($"Name: {product.Name} , Price: {product.Price} , Average Rating: {product.AverageRating}");
            }
        }
        public static void DeactivateOutOfStockProducts(this AppDbContext context)
        {
            context.Products.Where(p => p.StockQuantity == 0)
                            .ExecuteUpdate(p => p.SetProperty(x => x.IsActive, false));
            var tracked = context.ChangeTracker.Entries();
            System.Console.WriteLine($"{tracked.Count()} row(s) affected");
        }
        public static void PlaceOrder(this AppDbContext context)
        {
            System.Console.Write("Customer Id: ");
            int customerId = int.Parse(Console.ReadLine()!);
            using(var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var customer = context.Customers.Find(customerId);
                    var order = new Order() { Customer = customer! , PlacedAt = DateTime.Now};
                    var orderItems = new List<OrderItem>();
                    AddOrderItems(orderItems, order);
                    context.Orders.Add(order);
                    context.OrderItems.AddRange(orderItems);
                    context.SaveChanges();

                    context.Products.Include(p => p.OrderItems)
                                    .Where(p => orderItems.Any(oi => oi.ProductId == p.ProductId))
                                    .ToList()
                                    .ForEach(p =>
                                    {
                                        var orderedQuantity = orderItems.Where(oi => oi.ProductId == p.ProductId).Sum(oi => oi.Quantity);
                                        p.StockQuantity -= orderedQuantity;
                                        if (p.StockQuantity < 0)
                                        {
                                            throw new Exception($"Not enough stock for product {p.Name}");
                                        }
                                    });
                    context.SaveChanges();

                    var totalPrice = orderItems.Sum(oi => oi.Quantity * oi.UnitPrice);
                    order.TotalAmount = totalPrice;
                    context.SaveChanges();

                    var payment = new Payment() { Order = order };
                    context.Payments.Add(payment);
                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
        public static void AddOrderItems(List<OrderItem> orderItems, Order order)
        {
            char continueAdding;
            do
            {
                System.Console.Write("Product Id: ");
                int productId = int.Parse(Console.ReadLine()!);
                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine()!);
                var orderItem = new OrderItem() { ProductId = productId, Quantity = quantity, Order = order };
                orderItems.Add(orderItem);

                System.Console.Write("Add another item? (Y/N): ");
                continueAdding = char.ToUpper(Console.ReadKey().KeyChar);
                System.Console.WriteLine();
                if(continueAdding != 'Y' && continueAdding != 'N')
                {
                    System.Console.Write("Invalid input. Please enter Y or N, Insert Again: ");
                    continueAdding = char.ToUpper(Console.ReadKey().KeyChar);
                }
            } while (continueAdding == 'Y');
        }
        public static void ViewOrderHistory(this AppDbContext context)
        {
            System.Console.Write("Customer Id: ");
            int customerId = int.Parse(Console.ReadLine()!);

            var orders = context.Orders.Include(o => o.OrderItems)
                                        .Include(o => o.Payment)
                                        .Where(o => o.CustomerId == customerId)
                                        .OrderByDescending(o => o.PlacedAt)
                                        .AsNoTracking()
                                        .ToList();

            var recentOrder = orders.FirstOrDefault();
            if (recentOrder != null)
            {
                System.Console.WriteLine($"Most Recent Order:\n{recentOrder}");
            }
            System.Console.WriteLine("Orders:");
            foreach(var order in orders)
            {
                System.Console.WriteLine(order);
            }
        }
        public static void CancelPendingOrder(this AppDbContext context)
        {
            System.Console.Write("Customer Id: ");
            int customerId = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Order Id: "); 
            int orderId = int.Parse(Console.ReadLine()!);

            using(var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Orders.Where(o => o.OrderId == orderId && o.CustomerId == customerId)
                                    .ExecuteUpdate(o => o.SetProperty(s => s.Status , s => OrderStatus.Cancelled));
                    context.SaveChanges();

                    context.OrderItems.Include(oi => oi.Order)
                                    .Include(oi => oi.Product)
                                    .Where(oi => oi.OrderId == orderId)
                                    .ExecuteUpdate(oi => oi.SetProperty(
                                        sq => sq.Product.StockQuantity , sq => sq.Product.StockQuantity + sq.Quantity
                                        ));
                    context.SaveChanges();

                    context.Orders.Include(o => o.Payment)
                                    .Where(o => o.OrderId == orderId)
                                    .ExecuteUpdate(o => o.SetProperty(ps => ps.Payment!.Status , ps => PaymentStatus.Refunded));
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    System.Console.WriteLine($"Exception: {e.Message}");
                }
            }
        }
        public static void MonthlyRevenueReport(this AppDbContext context)
        {
            var report = context.Orders.AsNoTracking()
                                        .Where(o => o.Status == OrderStatus.Delivered)
                                        .GroupBy(o => o.PlacedAt.Month)
                                        .Select(g => new
                                        {
                                           Month = g.Key ,
                                           Revenue = g.Sum(o => o.TotalAmount) 
                                        });

            foreach(var month in report)
            {
                System.Console.WriteLine($"Month: {month.Month}, Revenue: {month.Revenue}");
            }
        }
    }
}