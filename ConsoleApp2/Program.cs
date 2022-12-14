using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        int id;
        string name;

        public Program(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
       

        static void Main(string[] args)
        {
            int id = 10;
            string name = "chetan";
            //classes are reference types so they passed address of variable not a copy 
            Program p = new Program(id, name);
            Program p1 = p;
            p1.name = "badgujar";
            Console.WriteLine(p.name);

            //structs are value types instead of passing of address they passed the copy  of variable
            StructExample s = new StructExample(id ,name);
            StructExample s1 = s;
            s1.Id = 20;
            Console.WriteLine(s.Id);
            Console.WriteLine(s.ToString());


            Console.ReadLine();
        }
    }
    public struct StructExample
    {
       public int Id { get; set; }
        public string Name { get; set; }


        //struct dont have parameterless constructor
        // we cannot initialize struct variables at the time of declaration
        //structs are value type so it creates the copy of variable so it doesnt affect original variable
        public StructExample(int id ,String name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"({Id} : {Name})";
       


    }
}
