using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeWhile_Partition_Operator
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string[] Countries = { "US", "UK", "China", "Russia", "Argentina", "India" };
        //    IEnumerable<string> Country = Countries.TakeWhile(x => x.StartsWith("U"));
        //    foreach(var country in Country)
        //    {
        //        Console.WriteLine(country);
        //    }
        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            string[] Countries = { "US", "UK", "China", "Russia", "Argentina", "India" };
            IEnumerable<string> Country = (from x in Countries
                                           select x).TakeWhile(x => x.StartsWith("U"));
            foreach (var country in Country)
            {
                Console.WriteLine(country);
            }
            Console.ReadLine();
        }
    }
}
