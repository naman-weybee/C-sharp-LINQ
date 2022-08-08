using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLookup_Method
{
    public class LookUp
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<LookUp> Student = new List<LookUp>()
            {
                new LookUp(){Name = "Ayush", Department = "EC", Country = "India"},
                new LookUp(){Name = "Yash", Department = "IT", Country = "UK"},
                new LookUp(){Name = "Satish", Department = "EC", Country = "Japan"},
                new LookUp(){Name = "Raj", Department = "ME", Country = "US"},
                new LookUp(){Name = "Trshal", Department = "CE", Country = "India"},
            };

            var ObjStudent = Student.ToLookup(x => x.Department);
            Console.WriteLine("Grouping Students by Department");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            foreach (var item in ObjStudent)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var item1 in ObjStudent[item.Key])
                {
                    Console.WriteLine("\t" + item1.Name + " " + item1.Department + " " + item1.Country);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }


    //public class LookUp
    //{
    //    public string Name { get; set; }
    //    public string Department { get; set; }
    //    public string Country { get; set; }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<LookUp> Student = new List<LookUp>()
    //        {
    //            new LookUp(){Name = "Ayush", Department = "EC", Country = "India"},
    //            new LookUp(){Name = "Yash", Department = "IT", Country = "UK"},
    //            new LookUp(){Name = "Satish", Department = "EC", Country = "Japan"},
    //            new LookUp(){Name = "Raj", Department = "ME", Country = "US"},
    //            new LookUp(){Name = "Trshal", Department = "CE", Country = "India"},
    //        };

    //        var ObjStudent = (from x in Student
    //                          select x).ToLookup(x => x.Department);
    //        Console.WriteLine("Grouping Students by Department");
    //        Console.WriteLine("---------------------------------");
    //        Console.WriteLine();
    //        foreach (var item in ObjStudent)
    //        {
    //            Console.WriteLine(item.Key + ":");
    //            foreach (var item1 in ObjStudent[item.Key])
    //            {
    //                Console.WriteLine("\t" + item1.Name + " " + item1.Department + " " + item1.Country);
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
