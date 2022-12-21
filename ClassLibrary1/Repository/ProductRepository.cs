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
        public static List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId=1,
                    CurrentPrice=500,
                    ProductName="memorycard",
                    ProductDescription="for storing a data"


                },
                new Product
                 {
                      ProductId=2,
                    CurrentPrice=700,
                    ProductName="pendrive",
                    ProductDescription="it stores a data"
                  },
                new Product {

                    ProductId=3,
                    CurrentPrice=1000,
                    ProductName="hard disk",
                    ProductDescription="it stores a large amount of data"
                },
                  new Product {

                    ProductId=4,
                    CurrentPrice=1500,
                    ProductName="keyboard",
                    ProductDescription="use for input the data"
                },
                  new Product {

                    ProductId=5,
                    CurrentPrice=2000,
                    ProductName="webcam",
                    ProductDescription="use for  video streaming on pc"
                }
            };
        }
        public bool save()
        {
            return true;
        }


    }
}
