using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    public class Class1
    {
        static void Main(string[] args)
        {
            SampleViewModel vm = new SampleViewModel
            {
                UseQuerySyntax = true,
            };
            //vm.GetAllLooping();
            //vm.OrderBy();
            vm.WhereExpreession();
            foreach (var item in vm.Products)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
