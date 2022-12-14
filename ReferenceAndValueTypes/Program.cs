using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    internal class Program
    {
        string book;
       

        public Program (string book)
        {
            this.book = book;
        }   

        public void  ValueAsRefernce(ref int a)
        {
            a++;
        }
        public void ValueAsRefernce2(out int a)
        {
            a = 10;
        }



        static void Main(string[] args)
        {   //pass by refernce
            Program p = new Program("atomic habbits");
            Program p2 = p;
            p2.book = "attitude is everything";
            Console.WriteLine(p.book);

            //pass by value
            int a = 7;
            int b = a;
            b = 5;
            Console.WriteLine(a);

            //pass value as refrence with ref
            p.ValueAsRefernce( ref a);

            Console.WriteLine(a);

            //pass value as refrence with out;

            p.ValueAsRefernce2(out a);

            Console.WriteLine(a);

            Console.ReadLine();

        }
    }
}
