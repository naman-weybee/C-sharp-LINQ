using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Max_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int max = arr.Max();
            Console.WriteLine("Maximum Value in Array is: " + max);
            Console.WriteLine();


            List<int> newList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,0
            };
            int maxList = newList.Max();
            Console.WriteLine("Maximum Value in List is: " + maxList);
            Console.ReadLine();
        }
    }
}
