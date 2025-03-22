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

    }
}
