using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    
    public class LinkedListExample
    {
      
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);   
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddLast(4);
            list.AddLast(5);
            

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
