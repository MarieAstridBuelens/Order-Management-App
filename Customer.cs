using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_App
{
    internal class Customer
    {
        //Properties
        private int _CustomerId;
        public int CustomerId
        { 
            get { return _CustomerId; } 
            set { _CustomerId = value; }
        }

        private string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        private string _CustomerEmail;
        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
        }

        private DateTime _CustomerRegistrationDate;
        public DateTime CustomerRegistrationDate
        {
            get { return _CustomerRegistrationDate; }
            set { _CustomerRegistrationDate = value; }
        }

    }
}
