using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_App
{
    internal class InsufficientStockException : Exception
    {
        public InsufficientStockException()
            : base("Insufficient stock available for the requested quantity.") 
        {

        }

        public InsufficientStockException(string message)
            : base(message)
        {

        }
    }
}
