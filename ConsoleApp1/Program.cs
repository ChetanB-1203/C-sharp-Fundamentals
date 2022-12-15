using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    public delegate void Mydelegate(int x, int y);
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int addNums(int a , int b)
        {
            return a + b;
        }
        public void areaRect(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public void perimeterRect(int a, int b)
        {
            Console.WriteLine(2*(a + b));
        }
        public object this[int index]{
            get
            {
                if (index == 0)
                    return id;

                else if (index == 1)
                    return name;
                return null;
             }

        }

        static void Main(string[] args)
        {
            /* Employee e = new Employee(1, "chetan");
             Console.WriteLine(e[0]);
             Console.WriteLine(e[1]);
             Console.ReadLine();*/
            Employee e = new Employee();
            Mydelegate md = e.areaRect;
         
            md += e.perimeterRect;
            md(20, 30);
            Mydelegate md2 = delegate (int x, int y)
            {
                Console.WriteLine(2*x+2*y);
            };
            md2.Invoke(100, 200);
            Mydelegate md3 = (int x, int y) =>
            {
                Console.WriteLine(x * x * x + y * y * y);
            };
            md3.Invoke(5, 6);
            Func<int, int, int> obj = (x, y) =>
            {
                return (x + y);
            };
            Console.WriteLine(obj.Invoke(7, 6));





            //Date and time

            DateTime testDate = new DateTime(2022, 12, 11, 15, 30, 0);
            Console.WriteLine(testDate);

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            bool areWeInDst =currentDate.IsDaylightSavingTime(); 
            Console.WriteLine(areWeInDst);
            DateTime start = DateTime.Now;
            TimeSpan t = new TimeSpan(9, 0, 0);
            DateTime end = start.Add(t);
            Console.WriteLine(end.ToLongDateString());



            //Strings
            string firstName = "Chetan";
            string lastName = "Badgujar";

            Console.WriteLine($"{firstName}  {lastName}");

            string a = "hello";
             string b = "hello";
            char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' } ;
            string c = new String(letters);
            Console.WriteLine(a==b);
            Console.WriteLine(c==a);
            Console.WriteLine(a.Equals(c));
           

            Employee e1 = new Employee(1, "Chetan");
            Employee e2 = new Employee(1, "Chetan");
            Employee e3 = e2;

            Console.WriteLine(e1==e2);
            Console.WriteLine(e1.Equals(e3)); 

            Console.ReadLine();
        }
    }
}
