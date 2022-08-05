using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Aggregate_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            var avg = arr.Aggregate((a, b) => a + b);
            Console.WriteLine(avg);
            Console.WriteLine();


            List<int> IntList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            var avgList = IntList.Aggregate((a, b) => a * b);
            Console.WriteLine(avgList);
            Console.WriteLine();


            string[] arr1 = { "ayush", "jonas", "jay", "ankit", "dev" };
            var charts = arr1.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine(charts);
            Console.WriteLine();


            List<string> StrNewList = new List<string>()
            {
                "ayush", "jonas", "jay", "ankit", "dev"
            };
            var StrList = StrNewList.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine(StrList);
            Console.ReadLine();
        }
    }
}
