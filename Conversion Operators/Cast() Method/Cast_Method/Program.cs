using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add("USA");
            obj.Add("Australia");
            obj.Add("UK");
            obj.Add("India");
            IEnumerable<string> result = obj.Cast<string>();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Type t = obj.GetType();
            Type r = result.GetType();
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<object> obj = new List<object>();
    //        obj.Add("USA");
    //        obj.Add("Australia");
    //        obj.Add("UK");
    //        obj.Add("India");
    //        IEnumerable<string> result = obj.Cast<string>();
    //        foreach (string s in result)
    //        {
    //            Console.WriteLine(s);
    //        }
    //        Type t = obj.GetType();
    //        Type r = result.GetType();
    //        Console.WriteLine(t);
    //        Console.WriteLine(r);
    //        Console.ReadLine();
    //    }
    //}
}
