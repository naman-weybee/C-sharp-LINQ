using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOrDefault_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[] arr1 = { };
            var First = arr.FirstOrDefault();
            var First1 = arr1.FirstOrDefault();
            Console.WriteLine(First);
            Console.WriteLine(First1);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };
    //        int[] arr1 = { };
    //        var First = (from x in arr
    //                     select x).FirstOrDefault();
    //        var First1 = (from x in arr1
    //                      select x).FirstOrDefault();
    //        Console.WriteLine(First);
    //        Console.WriteLine(First1);
    //        Console.ReadLine();
    //    }
    //}
}
