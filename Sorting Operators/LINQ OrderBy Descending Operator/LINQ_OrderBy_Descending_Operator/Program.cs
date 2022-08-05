using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OrderBy_Descending_Ascending
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> objStudents = new List<Student>()
            {
                new Student()
                {
                    Name = "Rahul",
                    Gender = "Male",
                    Subjects = new List<string>{ "Java", "Maths"}
                },
                new Student()
                {
                    Name = "Ayush",
                    Gender = "Male",
                    Subjects = new List<string>{"Physics", "Maths","Chemestry"}
                },
                new Student()
                {
                    Name = "Hitarthi",
                    Gender = "Female",
                    Subjects = new List<string>{"Compt", "Maths", "Antenna"}
                },
                new Student()
                {
                    Name = "Jonas",
                    Gender = "Male",
                    Subjects = new List<string>{"Maths", "English", "Java", "C++", "C#" }
                },
                new Student()
                {
                    Name = "Shruti",
                    Gender = "Female",
                    Subjects = new List<string>{ "Maths", "Maths", "Java", "C", "Android" }
                }
            };

            var StudentName = objStudents.OrderByDescending(x => x.Name);

            foreach (var st in StudentName)     // Display Only Student Name
            {
                Console.WriteLine("Name: " + st.Name);
            }
            Console.WriteLine();

            foreach (var st in StudentName)       // Display Whole Student Object
            {
                var stSub = st.Subjects;
                Console.Write("Name: " + st.Name + ", Gender: " + st.Gender + ", Subjects: ");
                foreach (var sts in stSub)
                {
                    Console.Write(sts + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
