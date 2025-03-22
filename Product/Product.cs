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
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private decimal _Price;
        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private int _StockQuantity;
        public int StockQuantity
        {
            get { return _StockQuantity; }
            set { _StockQuantity = value; }
        }

        public void Sell()
        {
            try
            {
                int x = 0;
                int y = 10 / x;

                Console.WriteLine(y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
