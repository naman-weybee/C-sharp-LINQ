using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIP_OPERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };
            IEnumerable<string> Country = Countries.Skip(2);
            foreach (string country in Country)
            {
                Console.WriteLine(country);
            }
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] Countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };
    //        IEnumerable<string> Country = (from x in Countries
    //                                       select x).Skip(3);
    //        foreach (string country in Country)
    //        {
    //            Console.WriteLine(country);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
