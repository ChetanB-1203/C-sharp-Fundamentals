using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;    
        }
         
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public String FisrtName { get; set; }
        public String LastName { get; set; }



        public string FullName
        {
            get { return LastName + " " + FisrtName; }

        }

        public bool validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;

            return isValid;

        }

       
    }
}
