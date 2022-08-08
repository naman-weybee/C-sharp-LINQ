using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementAt_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var Ele = arr.ElementAt(3);
            var Ele1 = arr.ElementAt(7);
            var Ele2 = arr.ElementAt(9);
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
    //        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
    //        var Ele = (from x in arr
    //                   select x).ElementAt(3);
    //        var Ele1 = (from x in arr
    //                    select x).ElementAt(7);
    //        var Ele2 = (from x in arr
    //                    select x).ElementAt(9);
    //        Console.WriteLine(Ele);
    //        Console.WriteLine(Ele1);
    //        Console.WriteLine(Ele2);
    //        Console.ReadLine();
    //    }
    //}
}
