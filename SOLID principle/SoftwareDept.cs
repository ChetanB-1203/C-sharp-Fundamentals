using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public class SoftwareDept : IEmployee
    {   
        //here child class behaves like parent class so it follows LSP principle
        public  void GetEmployeeDetails(int deptId)
        {
            Console.WriteLine("software dept employee list"); 
        }
    }
}
