using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{     

    public abstract class Car
    {
        public string Colour { get; set; } = "Black";


        public void accelerate()
        {
            Console.WriteLine("Do something to accelerate");
        }
        public void applyBrakes()
        {
            Console.WriteLine("Do something to apply brakes");
        }
        public abstract void changeGears();
    }
public class Alto :Car
{  
   public override void changeGears()
    {
     Console.WriteLine("Implement changeGears() method for Alto Car");
    }
}
public class Santro : Car
{
   public override void changeGears()
    {
       Console.WriteLine ("Implement changeGears() method for Santro Car");
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Alto();

            Console.WriteLine(car.Colour);
            car.accelerate();
            Console.ReadLine();
        }
    }
}
