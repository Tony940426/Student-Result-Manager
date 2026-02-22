using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result_Manager
{
    public class Student : Person
    {
        public int Age { get; set; }
        public int[] Marks { get; set; }

        public Student(string name, int age, int[] marks) : base(name)
        {

            foreach (var mark in marks)
            {
                if (mark < 0 || mark > 100)
                {
                    Console.WriteLine("Cannot add students, grade is invalid");
                    return;
                }
            }
            this.Marks = marks;
            this.Age = age;
        }

        public void GetStudentInfo()
        {
            GetInfo();
            Console.WriteLine($"Age: {Age}, Grades: {string.Join(", ", Marks)}");
        }
    }
}
