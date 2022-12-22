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
            // vm.WhereExpreession();
            // vm.First();
            // vm.All();
            //vm.LINQContainsUsingComparer();
            //vm.CountFiltered();
            vm.FindMinimum();
            foreach (var item in vm.Products)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(vm.ResultText);
            
            Console.ReadLine();
        }
    }
}
