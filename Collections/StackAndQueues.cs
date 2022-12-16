using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public  class StackAndQueues
    {
       


         static void Main2(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            Stack<int> stack = new Stack<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);   
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Dequeue();



            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            } 
            Console.WriteLine();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
