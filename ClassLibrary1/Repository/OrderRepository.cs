using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public  class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(orderId>0 && orderId < 10)
            {
                order.OrderDate = DateTime.Now;
                
            }
            return order;
        }


        public bool Save() => true;
    }
}
