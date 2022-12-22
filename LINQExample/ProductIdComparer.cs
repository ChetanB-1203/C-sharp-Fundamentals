using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    public class ProductIdComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product x, Product y)
        {
           return (x.ProductId == y.ProductId); 
        }

        public override int GetHashCode(Product obj)
        {
            return obj.ProductId.GetHashCode();
        }
    }
}
