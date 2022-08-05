using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lambda_Expression_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Countries = new List<string>()
            {
                "india", "us", "uk", "russia", "china"
            };
            //var country = Countries.Select(x => x);
            IEnumerable<string> country = Countries.Select(x => x);
            foreach(var item in country)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
