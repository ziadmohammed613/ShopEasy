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
    }
}