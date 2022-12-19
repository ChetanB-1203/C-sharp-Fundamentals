using Interfaces_in_C_sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class List
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            list.Add(new Person("Virat", 34));
            list.Add(new Person("Rohit", 35));
            list.Add(new Person("Shikhar", 36));
            list.Add(new Person("SKY", 31));

            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(list.GetHashCode());
            Console.WriteLine();


            ArrayList arraylist = new ArrayList();

            arraylist.Add("chetan");
            arraylist.Add(20);
            arraylist.Add(true);
            arraylist.Add(30.0f);

            foreach (var item in arraylist)
            {
                Console.WriteLine(item.ToString());
            }


            
            Console.ReadLine();
        }

    }
}
