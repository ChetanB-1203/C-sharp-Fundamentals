using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public  class ExcelReportGeneration :IReportGeneration
    {
        public override void GenerateReport(Employee emp)
        {
            Console.WriteLine("Excel report generated");
        }
    }
}
