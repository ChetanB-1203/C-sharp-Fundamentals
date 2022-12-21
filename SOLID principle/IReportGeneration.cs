using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public class IReportGeneration
    {   

        //here this class follows OCP if in future someone add report in different types so
        //they can extend this class here no need of modification but open for extension
        public virtual void GenerateReport(Employee emp)
        {
            Console.WriteLine("report generated");
        }
    }
}
