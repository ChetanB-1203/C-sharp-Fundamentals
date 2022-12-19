using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class OrderItem
    {
        public Product ProductDetails { get; set; } 
        public int Quantity { get; set; }

        public double PurchasePrice { get; set; }   

        public bool Validate()
        {  
            bool isValid = true;
            if (Quantity <= 0) isValid = false;

            return isValid;
        }

        
            
    }
}
