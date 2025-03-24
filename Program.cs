using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customers instances
            Customer customer001 = new Customer() { CustomerId = 001, CustomerName = "Laurent Dupont", CustomerEmail = "ldupont@yahoo.fr", CustomerRegistrationDate = new DateTime(2011, 6, 10) };
            Customer customer002 = new Customer() { CustomerId = 002, CustomerName = "Hikaru Tanaka", CustomerEmail = "htanaka@gmail.com", CustomerRegistrationDate = new DateTime(2023, 8, 28) };

            //Product instances
            Product product001 = new Product() { ProductId = 001, ProductName = "Smartphone Sheep", ProductPrice = 124.99M, ProductStockQuantity = 7 };
            Product product002 = new Product() { ProductId = 002, ProductName = "Smartphone Popular 4.1", ProductPrice = 239.99M, ProductStockQuantity = 2 };
            Product product003 = new Product() { ProductId = 003, ProductName = "Smartphone Xpensive 3", ProductPrice = 599.99M, ProductStockQuantity = 23 };
            Product product004 = new Product() { ProductId = 004, ProductName = "Hair Dryer Vivo", ProductPrice = 25.45M, ProductStockQuantity = 0 };
            Product product005 = new Product() { ProductId = 005, ProductName = "Gaming Mice Pro", ProductPrice = 97.65M, ProductStockQuantity = 1 };
        
            //Order simulation
            Console.WriteLine($"You are now successfully logged in, {customer001.CustomerName}.");
            Console.WriteLine($"{customer001.CustomerName} tries to add {product001.ProductName} in the shopping cart.");
            int quantity = 1;
            Console.WriteLine($"Quantity : {quantity}");
            Console.ReadLine();




        }
    }
}
