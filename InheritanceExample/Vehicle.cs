using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public  class Vehicle
    {
        public int a = 10;
       public Vehicle()
        {
            Console.WriteLine("Vehicle class constructor");
        }
        public Vehicle(int i)
        {
            Console.WriteLine("Vehicle class  argument constructor");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle drive method");
        }

        public virtual void  Drive2()
        {
            Console.WriteLine("Vehicle drive method");
        }
        
    }

    public class  FourWheeler : Vehicle
    {
        public FourWheeler():base(10)
        {
           
            Console.WriteLine(base.a);
            Console.WriteLine("Fourwheeler class constructor");
        }

        //overriding
        public override void Drive()
        {
            Console.WriteLine("Fourwheeler drive method");
        }
        


        // method hiding
        public new void Drive2()
        {
            Console.WriteLine("Fourwheeler drive method");
            
        }

    }
    public class FourwheeelerMain
    {
        static void Main(string[] args)
        {
            Vehicle fw = new FourWheeler();
            fw.Drive2();
            Console.ReadLine();

        }
    }
}
