using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    internal class Program
    {    


        static void Main(string[] args)
        {

            Nullable<int> i = null;

            //we can use hasvalue which returns true if i has a value
            if(i.HasValue)
                Console.WriteLine(i.Value);
            Console.WriteLine("null");

            //print default value if its null else actual value
            Console.WriteLine(i.GetValueOrDefault());

            //shorthand syntax for nullable
            int ? j = null;

            // ?? to assign nullable type to non nullable type --> null coalescing operator
            int k = i ?? 10;
            Console.WriteLine(k);

            string s1 = "";
            Console.WriteLine(s1.Length);


            //conditional operator
            int m = j.HasValue ? j.Value : -1;



            Console.ReadLine();
        }
    }
}
