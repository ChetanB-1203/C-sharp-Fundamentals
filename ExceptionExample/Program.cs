using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("you are dividing by zero");
            }
            catch(Exception)
            {
                Console.WriteLine("exception occured");
            }
            finally
            {
                Console.WriteLine("finally block");
                
            }
            Console.ReadLine();
        }
    }
}
