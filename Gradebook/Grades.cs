using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public  class Students
    {
        public int m1;
        public int m2;
        public int m3;

        public Students(int m1, int m2, int m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;   
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input no of students");
            var n = Console.Read();
            Students[] s = new Students[n];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter marks 1 of Student {s[i]} ");
                var m1 = Console.Read();
                Console.WriteLine($"Enter marks 2 of Student {s[i]} ");
                var m2 = Console.Read();
                Console.WriteLine($"Enter marks 3 of Student {s[i]} ");
                var m3 = Console.Read();

                s[i] = new Students(m1, m2, m3);
            }
        }
    }

     class Marks
    {
        public int[] CalculateGrades(Students[]s)
            {
            int sum = 0;
            int avg = 0;
            int[] percentage = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
               sum += s[i].m1+s[i].m2+s[i].m3;
                percentage[i] = sum/s.Length;
                sum = 0;
            }

           
        }



    }
}
