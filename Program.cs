using System;
using Microsoft.EntityFrameworkCore;
using ShopEasy.Data;
using ShopEasy.Models;
using Microsoft.EntityFrameworkCore.Proxies;

namespace ShopEasy
{
    public static class Program
    {
        public static void Main()
        {
            var context = new AppDbContext();
        }
        public static void Register(this AppDbContext context, Customer customer , CustomerProfile customerProfile)
        {
            using(var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    context.Customers.Add(customer);
                    context.CustomerProfiles.Add(customerProfile);
                    context.SaveChanges();

                    transaction.Commit();
                    System.Console.WriteLine("Customer Registerd Successfully!");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    System.Console.WriteLine($"Exception! {e.Message}");
                }
            }
        }
        public static void ViewCustomerProfile(this AppDbContext context, int customerId)
        {
            try
            {
                var customerProfile = context.CustomerProfiles.Single(cp => cp.CustomerId == customerId);
                System.Console.WriteLine(customerProfile);
            }
            catch
            {
                System.Console.WriteLine("Couldn't find customer");
            }
            
        }
        public static void UpdataAddress(this AppDbContext context, Customer customer , string newAddr)
        {
            var customerProfile = context.CustomerProfiles.Include(cp => cp.Customer)
                                                            .SingleOrDefault(cp => cp.Customer == customer);
            
            if(customerProfile != null)
            {
                customerProfile.Address = newAddr;
                context.SaveChanges();
                System.Console.WriteLine("Address Updated Successfully");
            }
            else
            {
                customerProfile = new CustomerProfile { Customer = customer , Address =  newAddr };
                System.Console.WriteLine("New Profile Created");
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
        public enum SearchBy { Category , Name }
        public static void SearchProduct(this AppDbContext context, SearchBy search , string Key)
        {
            if(search == SearchBy.Category)
            {
                var products = context.Products.Include(p => p.Category)
                                        .Where(p => p.IsActive)
                                        .Where(p => p.Category.Name.Contains(Key))
                                        .AsNoTracking();
                foreach(var product in products)
                {
                    System.Console.WriteLine(product);
                }
            }
            else if(search == SearchBy.Name)
            {
                var products = context.Products.Where(p => p.IsActive)
                                        .Where(p => p.Name.Contains(Key))
                                        .AsNoTracking();
                foreach(var product in products)
                {
                    System.Console.WriteLine(product);
                }
            }
        }
        public static void ViewProductDetails(this AppDbContext context, Product product)
        {
            var details = context.Products.Include(p => p.ProductTags)
                                                    .ThenInclude(pt => pt.Tag)
                                                    .Include(p => p.Reviews)
                                                    .Where(p => p == product)
                                                    .Select(p => new
                                                    {
                                                        p.Name,
                                                        p.Price,
                                                        Tags = p.ProductTags.Select(pt => pt.Tag.Name).ToList(),
                                                        Reviews = p.Reviews.Select(r => new { r.Rating, r.Comment }).ToList()
                                                    }).Single();
            
            System.Console.WriteLine($"Name: {details.Name} , Price: {details.Price}");
            System.Console.WriteLine("Tags:");
            foreach(var tag in details.Tags)
            {
                System.Console.WriteLine($"- {tag}");
            }
            int totalReviews = details.Reviews.Count;
            System.Console.WriteLine($"Total Reviews: {totalReviews}");

            double averageRating = totalReviews > 0 ? details.Reviews.Average(r => r.Rating) : 0;
            System.Console.WriteLine($"Average Rating: {averageRating}");

            System.Console.WriteLine("Reviews:");
            foreach(var review in details.Reviews)
            {
                System.Console.WriteLine($"- Rating: {review.Rating} , Comment: {review.Comment}");
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
        public static void PlaceOrder(this AppDbContext context , Customer customer , List<OrderItem> orderItems)
        {
            using(var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var order = new Order() { Customer = customer , PlacedAt = DateTime.Now , OrderItems = orderItems };
                    context.Orders.Add(order);
                    context.SaveChanges();
                    
                    context.OrderItems.AddRange(orderItems);
                    context.SaveChanges();
                    // exception here

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
                    System.Console.WriteLine("Order Placed Successfully!");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    System.Console.WriteLine($"Order Failed With Exception : {e.Message}");
                    throw;
                }
            }
        }
        /* public static void AddOrderItems(List<OrderItem> orderItems, Order order)
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
        } */
        public static void ViewOrderHistory(this AppDbContext context , Customer customer)
        {
            var orders = context.Orders.Include(o => o.OrderItems)
                                        .Include(o => o.Payment)
                                        .Where(o => o.Customer == customer)
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
                                        .OrderBy(o => o.Key)
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
        public static void ApplyDiscount(this AppDbContext context)
        {
            System.Console.Write("Order Id: "); 
            int orderId = int.Parse(Console.ReadLine()!);
            
            System.Console.Write("Discount Code: ");
            string discountCode = Console.ReadLine()!;
            using(var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var discount = context.Discounts.Single(d => d.Code == discountCode);
                    if(!discount.IsActive || discount.ExpiresAt <= DateTime.UtcNow)
                    {
                        throw new InvalidOperationException("Either discount is inactive or expiration date is invalid");
                    }
                    if(discount.CurrentUses >= discount.MaxUses)
                    {
                        throw new InvalidOperationException("Discount has already reached max uses");
                    }

                    context.Orders.Where(o => o.OrderId == orderId)
                                    .ExecuteUpdate(o => o.SetProperty(ta => ta.TotalAmount , ta => ta.TotalAmount + (ta.TotalAmount * (discount.Percentage / 100) ) ));
                    context.SaveChanges();

                    discount.CurrentUses++;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    System.Console.WriteLine($"Exception: {e.Message}");
                }
            }
        }
        public static void DeleteExpiredDiscounts(this AppDbContext context)
        {
            context.Discounts.Where(d => !d.IsActive || d.ExpiresAt <= DateTime.UtcNow)
                                .ExecuteDelete();
            var rows = context.ChangeTracker.Entries();
            System.Console.WriteLine($"{rows} row(s) affected");
        }
        public static void ViewReviews(this AppDbContext context)
        {
            // Lazy Loading Automatically
            var reviews = context.Reviews.ToList();
            foreach(var review in reviews)
            {
                System.Console.WriteLine(review);
            }
        }
        public static void LoadCustomerData(this AppDbContext context)
        {
            System.Console.Write("Customer Id: ");
            int customerId = int.Parse(Console.ReadLine()!);

            var data = context.Customers.Include(c => c.Orders)
                                        .ThenInclude(o => o.OrderItems)
                                        .Include(c => c.Reviews)
                                        .AsSplitQuery()
                                        .SingleOrDefault(c => c.CustomerId == customerId);

            var orders = data?.Orders.Select(o => new {
                                                    Order = o ,
                                                    o.OrderItems
                                                }).ToList();

            var reviews = data?.Reviews.ToList();
            foreach(var order in orders!)
            {
                System.Console.WriteLine($"Order:\n{order.Order}\nOrderItems:");
                foreach(var orderItem in order.OrderItems)
                {
                    System.Console.WriteLine(orderItem);
                }
            }
            System.Console.WriteLine("Reviews:");
            foreach(var review in reviews!)
            {
                System.Console.WriteLine(review);
            }
        }public static void ViewCustomersWithNoOrders(this AppDbContext context)
        {
            var customers = context.Customers.Include(c => c.Orders)
                                                .GroupJoin(context.Orders, c => c.CustomerId, o => o.OrderId, (customer, orders) => new
                                                {
                                                    CustomerName = customer.FullName,
                                                    CustomerEmail = customer.Email,
                                                    ordersCount = orders.Count()
                                                });

            foreach (var customer in customers)
            {
                if (customer.ordersCount == 0)
                {
                    System.Console.WriteLine($"{customer.CustomerName} - {customer.CustomerEmail}");
                }
            }
        }
        public static void ViewProductsQuantitySold(this AppDbContext context)
        {
            var products = context.Products.Include(p => p.OrderItems)
                                        .GroupJoin(context.OrderItems, p => p.ProductId, oi => oi.ProductId, (product, orderItems) => new
                                        {
                                            ProductName = product.Name,
                                            TotalSold = orderItems.Sum(oi => oi.Quantity)
                                        }).OrderByDescending(g => g.TotalSold);

            foreach (var product in products)
            {
                System.Console.WriteLine($"{product.ProductName} - {product.TotalSold}");
            }
        }
    }
}