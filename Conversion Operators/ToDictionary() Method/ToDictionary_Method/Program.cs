using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDictionary_Method
{
    public class Student
    {
        public int Id { get; set; }
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
                new Student(){ Id = 1, Name = "Ayush", Location = "Delhi"},
                new Student(){ Id = 2, Name = "Yash", Location = "Mumbai"},
                new Student(){ Id = 3, Name = "Rahul", Location = "Rajkot"},
                new Student(){ Id = 4, Name = "Dev", Location = "Pune"},
                new Student(){ Id = 5, Name = "Jay", Location = "surat"},
            };
            var student = students.ToDictionary(x => x.Id, x => x.Name);
            foreach(var st in student)
            {
                Console.WriteLine(st.Key + ": " + st.Value);
            }
            Console.ReadLine();
        }
    }
}
