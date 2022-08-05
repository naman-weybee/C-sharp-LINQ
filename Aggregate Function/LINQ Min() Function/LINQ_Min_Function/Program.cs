using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int min = arr.Min();
            Console.WriteLine("Minimum Value in Array is: " + min);
            Console.WriteLine();


            List<int> newList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,0
            };
            int minList = newList.Min();
            Console.WriteLine("Minimum Value in List is: " + minList);
            Console.ReadLine();
        }
    }
}
