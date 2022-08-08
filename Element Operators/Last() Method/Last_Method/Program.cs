using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            var Last = arr.Last();
            Console.WriteLine(Last);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };
    //        var Last = (from x in arr
    //                     select x).Last();
    //        Console.WriteLine(Last);
    //        Console.ReadLine();
    //    }
    //}
}
