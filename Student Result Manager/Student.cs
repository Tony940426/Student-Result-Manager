using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result_Manager
{
    public class Student : Person
    {
        public List<int> Marks { get; set; } = new List<int>();

        public Student(string name, int age, List<int> marks) : base(name)
        {
            foreach (var mark in marks)
            {
                if (!checkMarksAreValid(mark))
                {
                    Console.WriteLine($"Invalid mark {mark} for student {name}. Marks should be between 0 and 100.");
                }
                else
                {
                this.Marks.Add(mark);
                }
            }
        }
        private bool checkMarksAreValid(int mark)
        {
            if (mark > 0 && mark < 100)
            {
                return true;
            }
            else
            {
                return false;
            };
            
        }
        public override void GetInfo()
        {
            Console.WriteLine($"ID: {Id}, Name {Name}, Role: Student, Marks: {string.Join(", ", Marks)}");
        }

        public double CalculateAverage()
        {
            if (Marks.Count == 0) return 0;
            return Marks.Average();
        }
    }
}
