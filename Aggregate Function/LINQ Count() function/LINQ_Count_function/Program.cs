using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_count_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int arrCount = arr.Count();
            Console.WriteLine("Total no. of elements in the Array is: " + arrCount);
            Console.WriteLine();


            List<int> newList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,0
            };
            int ListCount = newList.Count();
            Console.WriteLine("Total no. of elements in the List is: " + ListCount);
            Console.ReadLine();
        }
    }
}
