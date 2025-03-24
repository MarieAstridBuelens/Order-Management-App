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

        //Methods
        public void AddProduct(Product product, int quantity)
        {
            if (product == null) throw new ArgumentNullException("The product has not been found.");
            else if (quantity <= 0) throw new ArgumentOutOfRangeException("The quantity is not valid.");
            else if (quantity > product.ProductStockQuantity) throw new InsufficientStockException();
            else
            {
                Products.Add(product);
            }
            
        }

        public decimal CalculateTotal()
        {
            foreach (Product product in Products)
            {
                TotalOrderAmount += product.ProductPrice;
            }
            return TotalOrderAmount;
        }

        public void ApplyDiscount(decimal percentage)
        {
            if (TotalOrderAmount > 300)
            {
                TotalOrderAmount *= percentage;
            }
        }
    }
}
