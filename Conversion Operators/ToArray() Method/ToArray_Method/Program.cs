﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToArray_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };
            IEnumerable<string> Country = Countries.ToArray();
            foreach (string country in Country)
            {
                Console.WriteLine(country);
            }
            Type t = Country.GetType();
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] Countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };
    //        IEnumerable<string> Country = (from x in Countries
    //                                       select x).ToArray();
    //        foreach (string country in Country)
    //        {
    //            Console.WriteLine(country);
    //        }
    //        Type t = Country.GetType();
    //        Console.WriteLine(t);
    //        Console.ReadLine();
    //    }
    //}
}
