using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAtOrDefault_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var Ele = arr.ElementAtOrDefault(3);
            var Ele1 = arr.ElementAtOrDefault(7);
            var Ele2 = arr.ElementAtOrDefault(15);
            Console.WriteLine(Ele);
            Console.WriteLine(Ele1);
            Console.WriteLine(Ele2);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //        var Ele = (from x in arr
    //                   select x).ElementAtOrDefault(3);
    //        var Ele1 = (from x in arr
    //                    select x).ElementAtOrDefault(7);
    //        var Ele2 = (from x in arr
    //                    select x).ElementAtOrDefault(15);
    //        Console.WriteLine(Ele);
    //        Console.WriteLine(Ele1);
    //        Console.WriteLine(Ele2);
    //        Console.ReadLine();
    //    }
    //}
}
