using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_sum_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int arrSum = arr.Sum();
            Console.WriteLine("Sum of all elements of the Array is: " + arrSum);
            Console.WriteLine();

            
            List<int> newList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,0
            };
            int ListSum = newList.Sum();
            Console.WriteLine("Sum of all elements of the List is: " + ListSum);
            Console.ReadLine();
        }
    }
}
