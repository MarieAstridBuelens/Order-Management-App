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
            Product product006 = null;

            // =====================
            // Title : Order simulation
            // =====================

            Console.WriteLine($"You are now successfully logged in, {customer001.CustomerName}.");

            //Order Creation
            Order order001 = new Order() { OrderId = 001, Customer = customer001, OrderDate = DateTime.Now, Products = new List<Product>(), TotalOrderAmount = 0M };
            Console.WriteLine("A new order has been created!");
            order001.OrderDisplay(order001);

            //Adding product001 in cart
            Console.WriteLine($"{customer001.CustomerName} tries to add {product001.ProductName} in the shopping cart.");
            int quantity = 1;
            Console.WriteLine($"Quantity : {quantity}. Press Enter to continue.");
            Console.ReadLine();
            order001.AddProduct(product001, quantity);
            Console.WriteLine($"{quantity} {product001.ProductName} added to your cart.");
            order001.CalculateTotal();
            order001.OrderDisplay(order001);
            Console.ReadLine();

            //Sell product001
            Console.WriteLine($"{customer001.CustomerName} tries to buy {product001.ProductName}.");
            product001.Sell(quantity);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            //trying to add 0 product004 in cart (handling exceptions)
            Console.WriteLine($"{customer001.CustomerName} tries to add {product004.ProductName} in the shopping cart.");
            quantity = 0;
            Console.WriteLine($"Quantity : {quantity}. Press Enter to continue.");
            Console.ReadLine();
            order001.AddProduct(product004, quantity);
            order001.OrderDisplay(order001);
            Console.ReadLine();


            //trying to add 2 product006 in cart (handling exceptions)

            //TO DO here: a new ArgumentNullException should be thrown to write down {product001.ProductName} and not "a new product" (hard-coded)
            Console.WriteLine($"{customer001.CustomerName} tries to add a new product in the shopping cart.");
            quantity = 2;
            Console.WriteLine($"Quantity : {quantity}. Press Enter to continue.");
            Console.ReadLine();
            order001.AddProduct(product006, quantity);
            order001.OrderDisplay(order001);
            Console.ReadLine();

            //Trying to buy 10 product 001 (handling exceptions)
            Console.WriteLine($"{customer001.CustomerName} tries to add {product001.ProductName} in the shopping cart.");
            quantity = 10;
            Console.WriteLine($"Quantity : {quantity}. Press Enter to continue.");
            Console.ReadLine();
            order001.AddProduct(product001, quantity);
            Console.WriteLine($"{quantity} {product001.ProductName} added to your cart.");
            order001.CalculateTotal();
            order001.OrderDisplay(order001);
            Console.ReadLine();
            Console.WriteLine($"{customer001.CustomerName} tries to buy {product001.ProductName}.");
            product001.Sell(quantity);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            



        }
    }
}
