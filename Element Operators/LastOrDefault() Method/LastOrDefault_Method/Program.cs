using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOrDefault_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[] arr1 = { };
            var Last = arr.LastOrDefault();
            var Last1 = arr1.LastOrDefault();
            Console.WriteLine(Last);
            Console.WriteLine(Last1);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };
    //        int[] arr1 = { };
    //        var Last = (from x in arr
    //                    select x).LastOrDefault();
    //        var Last1 = (from x in arr1
    //                     select x).LastOrDefault();
    //        Console.WriteLine(Last);
    //        Console.WriteLine(Last1);
    //        Console.ReadLine();
    //    }
    //}
}
