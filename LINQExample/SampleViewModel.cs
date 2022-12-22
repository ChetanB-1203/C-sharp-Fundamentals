using ClassLibrary1.Repository;
using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    public class SampleViewModel
    {
        public SampleViewModel()
        {
            Products = ProductRepository.GetAll();
        }
        public bool UseQuerySyntax = true;
        public List<Product> Products;
        public string ResultText;


        public void GetAllLooping()
        {
            List<Product> list = new List<Product>();

            foreach (Product item in Products)
            {
                list.Add(item);
            }
            ResultText = $"Total Products :{list.Count}";
        }
        public void GetAll()
        {

            List<Product> list = new List<Product>();
            if (UseQuerySyntax)
            {
                list = (from prod in Products select prod).ToList();
            }
            else
            {

                list = Products.Select(prod => prod).ToList();
            }
            ResultText = $"Total Products :{list.Count}";
            Console.WriteLine(ResultText);
        }
        public void GetSingleColumn()
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            if (UseQuerySyntax)
            {
                list.AddRange(from prod in Products select prod.ProductName);
            }
            else
            {

                list.AddRange(Products.Select(prod => prod.ProductName));
            }

            foreach (string item in list)
            {
                sb.AppendLine(item);
            }
            ResultText = $"Total Products :{list.Count}" + Environment.NewLine + sb.ToString();
            Console.WriteLine(ResultText);
            Products.Clear();

        }

        public void OrderBy()
        {
            if (UseQuerySyntax)
            {
                Products = (from prod in Products
                            orderby prod.ProductName
                            select prod).ToList();
            }
            else
            {

                Products = Products.OrderBy(prod => prod.ProductName).ToList();
            }
            ResultText = $"Total Products :{Products.Count}";
            Console.WriteLine(ResultText);
        }

        public void WhereExpreession()
        {
            string search = "p";
            if (UseQuerySyntax)
            {
                Products = (from prod in Products
                            where prod.ProductName.StartsWith(search)
                            select prod).ToList();
            }
            else
            {

                Products = Products.Where(prod => prod.ProductName.StartsWith(search)).ToList();
            }
            ResultText = $"Total Products :{Products.Count}";
            Console.WriteLine(ResultText);
        }
        public void First()
        {
            string search = "pendrive";
            Product value;
            try
            {
                if (UseQuerySyntax)
                {
                    value = (from prod in Products select prod).First(prod => prod.ProductName == search);
                }
                else
                {

                    value = Products.First(prod => prod.ProductName == search);
                }
                ResultText = $"Found:{value}";

            }
            catch
            {
                ResultText = "Notfound";
            }
        }
        public void All()
        {
            string search = "a";
            bool value;
            if (UseQuerySyntax)
            {
                value = (from prod in Products select prod).All(prod => prod.ProductName.Contains(search));

            }

            else
            {

                value = Products.All(prod => prod.ProductName.Contains(search));
            }
            ResultText = $"Do all name properties contain a {search} ? {value}";

            Products.Clear();

        }

        public void Any()
        {
            string search = "a";
            bool value;
            if (UseQuerySyntax)
            {
                value = (from prod in Products select prod).Any(prod => prod.ProductName.Contains(search));

            }

            else
            {

                value = Products.Any(prod => prod.ProductName.Contains(search));
            }
            ResultText = $"Do all name properties contain a {search} ? {value}";

            Products.Clear();

        }
        public void LINQContainsUsingComparer()
        {
            int search = 2;
            bool value;
            ProductIdComparer pc = new ProductIdComparer();
            Product prodToFind = new Product {ProductId = search};  
            if (UseQuerySyntax)
            {
                value = (from prod in Products select prod).Contains(prodToFind, pc);

            }

            else
            {

                value = Products.Contains(prodToFind, pc);  
            }
            ResultText = $"Product Id :{search}  is in Products Collection = {value}";

            Products.Clear();

        }
        public void CountFiltered()
        {
            int search = 500;
            int value;
            
            if (UseQuerySyntax)
            {
                value = (from prod in Products select prod).Count(prod => prod.CurrentPrice == search);

            }

            else
            {

                value = Products.Count(prod=>prod.CurrentPrice == search); 
            }
            ResultText = $"Products having price {search}  has count of {value}";

            Products.Clear();

        }
        public void FindMinimum()
        {
           
            double?value;

            if (UseQuerySyntax)
            {
                value = (from prod in Products select prod.CurrentPrice).Min();

            }

            else
            {

                value = Products.Min(prod=>prod.CurrentPrice);  
            }
            if (value.HasValue)
                ResultText = $"Minimum List Price ={value.Value}";
            else
                ResultText = "No list price exist";

            Products.Clear();

        }


    }
}