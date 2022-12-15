using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C_sharp
{
    public  class Person :IComparable,IComparer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;  
        }

        public int CompareTo(object obj)
        {   
           var person = (Person)obj;
            if (Age > person.Age)
                return 1;
            else if (Age < person.Age)  
                return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"[ {Name} : {Age}]";
        }

        public int Compare(object x, object y)
        {
           var person1 = (Person)x; 
           var person2 = (Person)y;

            return person1.Name.CompareTo(person2.Name);

        }
    }
}
