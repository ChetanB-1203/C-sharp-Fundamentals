using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public  class Employee
    {
      public int Employee_Id { get; set; }
      public int Employee_Name { get; set; }

        // this class has only one responsibility according SRP
        public bool InsertEmployee(Employee emp)
        {
            return true;
        }
    }
}
