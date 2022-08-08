using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add("Australia");
            obj.Add("India");
            obj.Add(1);
            obj.Add("UK");
            obj.Add("USA");
            obj.Add(5);

            IEnumerable<string> result = obj.OfType<string>();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<object> obj = new List<object>();
    //        obj.Add("Australia");
    //        obj.Add("India");
    //        obj.Add(1);
    //        obj.Add("UK");
    //        obj.Add("USA");
    //        obj.Add(5);

    //        IEnumerable<int> result = obj.OfType<int>();
    //        foreach (int s in result)
    //        {
    //            Console.WriteLine(s);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
