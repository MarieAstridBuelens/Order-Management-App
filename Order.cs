using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_App
{
    internal class Order
    {
        //Properties
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public bool DiscountApplied { get; set; }

        //Methods
        public void AddProduct(Product product, int quantity)
        {
            try
            {
                if (product == null) throw new ArgumentNullException("The product has not been found.");
                else if (quantity <= 0) throw new ArgumentOutOfRangeException("The quantity is not valid.");
                else
                {
                    for (int i = 0; i < quantity; i++)
                    {
                        Products.Add(product);
                    }
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Operation cancelled. Continuing with the next operation...");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Operation cancelled. Continuing with the next operation...");
            }

        }

        public decimal CalculateTotal()
        {
            foreach (Product product in Products)
            {
                TotalOrderAmount += product.ProductPrice;
            }
            ApplyDiscount(0.1M);
            return TotalOrderAmount;
        }

        public void ApplyDiscount(decimal percentage)
        {
            if (TotalOrderAmount > 300)
            {
                TotalOrderAmount *= (1 - percentage);
                DiscountApplied = true;
            }
        }

        public void OrderDisplay(Order order)
        {
            Console.WriteLine("Here are you order details:");
            Console.WriteLine($"    * Order ID = {order.OrderId}");
            Console.WriteLine($"    * Customer = {order.Customer.CustomerName}");
            Console.WriteLine($"    * Order Date = {order.OrderDate}");
            Console.WriteLine($"    * Products in cart = {order.Products.Count}");
            foreach (Product product in Products)
            {
                Console.WriteLine($"        - {product.ProductName} ({product.ProductPrice} euros)");
            }
            Console.WriteLine($"    * Total order amount = {order.TotalOrderAmount} euros");
            if (DiscountApplied)
            {
                Console.WriteLine($"        => A discount has been applied!");
            }
        }
    }
}
