using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C_sharp
{
    public class PersonMain
    {
         

        static void Main(string[] args)
        {
           
            Person walterWhite = new Person("walter", 45);
            Person jessiPinkaman = new Person("jessi", 26);
            Person gustavoFringe = new Person("guss", 42);
            Person saulGoodman = new Person("saul", 35);
            
            List<Person> list = new List<Person>();

            list.Add(walterWhite);
            list.Add(jessiPinkaman);
            list.Add(gustavoFringe);
            list.Add((saulGoodman));

            list.Sort();

            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
            }

            /*for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]);
            }*/
          

            Console.ReadLine(); 

           
        }
    }
}
