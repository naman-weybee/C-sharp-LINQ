using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numList = from num in numbers
                          where num < 7
                          select num;
            foreach (var item in numList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            List<int> integerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var FinalList = from i in integerList
                            where i > 3
                            select i;
            foreach (var item in FinalList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var newList = integerList.Where(obj => obj > 5).ToList();
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var newList1 = (from n in integerList
                            where n > 5
                            select n).Sum();
            Console.WriteLine(newList1);
            Console.ReadLine();
        }
    }
}
