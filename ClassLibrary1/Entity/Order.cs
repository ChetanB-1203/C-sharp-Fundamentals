using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class Order
    {
        public Order():this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
       public int CustomerId { get; set; }
       public int OrderId { get; set; }
       public DateTimeOffset OrderDate { get; set; }
       public List<OrderItem> OrderItems { get; set; }  
        public bool validate() => true;
      

       

    }
}
