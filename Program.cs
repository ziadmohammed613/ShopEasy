using System;
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
            try
            {
                System.Console.Write("Id: ");
                int CId = int.Parse(Console.ReadLine()!);
                var customer = context.CustomerProfiles.Single(cp => cp.CustomerId == CId);

                System.Console.Write("New Address: ");
                string newAddr = Console.ReadLine()!;
                customer.Address = newAddr;
                
                context.SaveChanges();
            }
            catch
            {
                System.Console.WriteLine("No Profile Found");
            }
        }
    }
}