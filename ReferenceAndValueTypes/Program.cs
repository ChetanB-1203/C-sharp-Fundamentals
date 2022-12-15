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
       
         public Program()
        {

        }

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
        static void changeBookName2( ref Program p, String book)
        {
            p = new Program();
            p.book = book;
        }


        static void Main(string[] args)
        {   //pass by refernce
            Program p = new Program("atomic habbits");
            Program p2 = p;
            p2.book = "attitude is everything";
            Console.WriteLine(p.book);


            Program p3 = new Program("attitude is everything");
            changeBookName2(ref p3, "think like a monk");
            Console.WriteLine( p3.book);

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

            string m = "chetan";
            String n = m;
            n = "badgujar";
            Console.WriteLine(m);

            Console.ReadLine();

        }
    }
}
