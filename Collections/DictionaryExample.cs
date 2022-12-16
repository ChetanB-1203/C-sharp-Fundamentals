using Collections;
using Interfaces_in_C_sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public  class DictionaryExample
    {

        static void Main2(string[] args)
        {
            Dictionary<int, Person> map = new Dictionary<int, Person>();

            map.Add(18, new Person("Virat", 34));
            map.Add(45, new Person("Rohit", 35));
            map.Add(42, new Person("Shikhar", 36));
            map.Add(63, new Person("SKY", 31));

            Console.WriteLine("Enter a jersey no");
            int  jerseyNo = int.Parse(Console.ReadLine());

            if (map.ContainsKey(jerseyNo))
                Console.WriteLine(map[jerseyNo]);

            foreach(var m in map.Values)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}