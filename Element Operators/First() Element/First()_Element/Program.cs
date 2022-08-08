using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First___Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            var First = arr.First();
            Console.WriteLine(First);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };
    //        var First = (from x in arr
    //                     select x).First();
    //        Console.WriteLine(First);
    //        Console.ReadLine();
    //    }
    //}
}
