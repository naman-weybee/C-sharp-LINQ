using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultfEmpty_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr1 = { };
            var result = arr.DefaultIfEmpty();
            var result1 = arr1.DefaultIfEmpty();
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            foreach (int i in result1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
