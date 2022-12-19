using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public  class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {   Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FisrtName = "Chetan";
                customer.LastName = "Badgujar";
                customer.EmailAddress = "chetanbadgujar1203@gmail.com";

            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool save()
        {
            return true;
        }
    }
}
