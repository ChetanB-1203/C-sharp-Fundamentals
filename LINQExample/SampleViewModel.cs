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

            foreach(Product item  in Products)
            {
                list.Add(item);
            }
            ResultText = $"Total Products :{list.Count}";
        }
        public void GetAll()
        {
          
            List<Product> list=new List<Product>();
            if (UseQuerySyntax)
            {
                list =(from prod in Products select prod).ToList();
            }
            else {
            
               list = Products.Select(prod=>prod).ToList();
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

            foreach(string item in list)
            {
                sb.AppendLine(item);
            }
            ResultText = $"Total Products :{list.Count}"+Environment.NewLine + sb.ToString();
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
    }
}
