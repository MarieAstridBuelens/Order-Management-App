using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_App
{
    internal class Product
    {
        //Properties
        private int _ProductId;
        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private decimal _ProductPrice;
        public decimal ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }

        private int _ProductStockQuantity;
        public int ProductStockQuantity
        {
            get { return _ProductStockQuantity; }
            set { _ProductStockQuantity = value; }
        }

        //Methods
        public void Sell(int quantity)
        {
            try
            {
                if (ProductStockQuantity < quantity)
                {
                    throw new InsufficientStockException();
                }
                else
                {
                    ProductStockQuantity -= quantity;
                    Console.WriteLine($"Stock updated. New quantity of {ProductName}: {ProductStockQuantity}");
                }

            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Operation cancelled. Continuing with the next operation...");
            }
        }
    }
}
