using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public  interface Shape
    {
         void area();
    }

    public class Rectangle : Shape
    {
        double length;
        double breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
    
        public void area()
        {
            Console.WriteLine($"Area of rectangle : {length*breadth}");
           
        }
    }
    public class Circle : Shape
    {  
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;   
        }

        public void area()
        {
            Console.WriteLine($"Area of Circle : {Math.PI*radius*radius}");
        }
    }

    public class ShapeMain
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(20, 30);
            rect.area();    
            Shape circle = new Circle(20);  
            circle.area();
            Console.ReadLine();
        }
    }


}
