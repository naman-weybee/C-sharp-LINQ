using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ThenBy_Descending_Operator
{
    public class Student
    {
        public int RollNo { get; set; }
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
                    RollNo = 1,
                    Name = "Rahul",
                    Gender = "Male",
                    Subjects = new List<string>{ "Java", "Maths"}
                },
                new Student()
                {
                    RollNo = 2,
                    Name = "Ayush",
                    Gender = "Male",
                    Subjects = new List<string>{"Physics", "Maths","Chemestry"}
                },
                new Student()
                {
                    RollNo = 3,
                    Name = "Hitarthi",
                    Gender = "Female",
                    Subjects = new List<string>{"Compt", "Maths", "Antenna"}
                },
                new Student()
                {
                    RollNo = 4,
                    Name = "Jonas",
                    Gender = "Male",
                    Subjects = new List<string>{"Maths", "English", "Java", "C++", "C#" }
                },
                new Student()
                {
                    RollNo = 6,
                    Name = "Shruti",
                    Gender = "Female",
                    Subjects = new List<string>{ "Maths", "C", "Android" }
                },
                new Student()
                {
                    RollNo = 5,
                    Name = "Shruti",
                    Gender = "Female",
                    Subjects = new List<string>{ "Maths", "Maths", "Java", "C", "Android" }
                },
                new Student()
                {
                    RollNo = 7,
                    Name = "Shruti",
                    Gender = "Female",
                    Subjects = new List<string>{ "Maths", "Java", "Android" }
                }
            };

            var StudentName = objStudents.OrderBy(x => x.Name).ThenByDescending(x => x.RollNo);

            foreach (var st in StudentName)     // Display Only Student Name
            {
                Console.WriteLine("Name: " + st.Name + ", Roll No: " + st.RollNo);
            }
            Console.WriteLine();

            foreach (var st in StudentName)       // Display Whole Student Object
            {
                var stSub = st.Subjects;
                Console.Write("Name: " + st.Name + ", Roll No: " + st.RollNo + ", Gender: " + st.Gender + ", Subjects: ");
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
