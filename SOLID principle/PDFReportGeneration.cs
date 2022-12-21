using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principle
{
    public class PDFReportGeneration : IReportGeneration
    {

        //It follows SRP this class has only responsibility of report generation

        public override void GenerateReport(Employee emp)
        {
            Console.WriteLine("Pdf generated");
        }
    }
}
