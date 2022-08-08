using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsEnumrable_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            var result = arr.AsEnumerable();
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
