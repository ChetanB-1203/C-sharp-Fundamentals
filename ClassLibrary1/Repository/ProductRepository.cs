using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
           Product product= new Product(productId);

            if(productId==45)
            {
                product.CurrentPrice = 100;
                product.ProductName = "Painting";
                product.ProductDescription = "painting about  nature";
                
            }

            return product;
        }

        public bool save()
        {
            return true;
        }


    }
}
