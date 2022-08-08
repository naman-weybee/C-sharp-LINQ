using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault_Method
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Name = "Ayush", Gender = "Male", Location = "Pune"},
                new Student(){Name = "Yash", Gender = "Male", Location = "Delhi"},
                new Student(){Name = "Devanshi", Gender = "Female", Location = "Chennai"},
                new Student(){Name = "Jay", Gender = "Male", Location = "Rajkot"},
                new Student(){Name = "Sruti", Gender = "Female", Location = "Banglore"},
            };
            int[] obj = { 1, 2, 3, 4, 5, 1, 7 };
            var student = students.SingleOrDefault(s => s.Name == "Ayush");
            string result = student.Name;
            int val = obj.SingleOrDefault(s => s > 7);
            Console.WriteLine(result);
            Console.WriteLine(val);
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] obj = { 1, 2, 3, 4, 5, 6, 7 };
    //        int val = obj.SingleOrDefault();
    //        Console.WriteLine(val);
    //        Console.ReadLine();
    //    }
    //}
}
