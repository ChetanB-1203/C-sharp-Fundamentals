using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class Product
    {

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;  

        }
        public int ProductId { get; set; }  
        public string ProductName { get; set; } 
        public string ProductDescription { get; set; }

        public double? CurrentPrice { get; set; }    

        public bool Validate()
        {
            bool isValid = true;

            if(String.IsNullOrWhiteSpace(ProductName) || CurrentPrice<0)
                isValid=false;

            return isValid;
        }

        public override string ToString() => $"Product-Id :{ProductId} Product Name :{ProductName}  Current Price :{CurrentPrice}";





    }
}
