using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Method1();
            class1.Method2();
            class1.Method3();   
            Console.ReadLine();
        }
    }

    public  sealed class Class1
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }

    }

    public static class Class2
    {
        public static void Method3(this Class1 x)
        {
            Console.WriteLine("Method 3");
        }
    }

}
