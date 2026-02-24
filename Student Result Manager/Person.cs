using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result_Manager
{
    public abstract class Person
    {
        private static int IdCounter = 1;
        private static List<Person> peoples = new List<Person>();

        public int Id { get; private set; }
        public string Name { get; set; }
        //this is the same as private string name
        //public string Name  
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public Person(string name)
        {
            this.Id = IdCounter++;   
            this.Name = name;
            peoples.Add(this);
        }

        public abstract void GetInfo();
        public static List<Person> GetPeoples()
        {
            return peoples;
        }

        public static void GetTopStudent()
        {
            Student? topStudent = peoples
                .OfType<Student>()
                .OrderByDescending(s => s.CalculateAverage())
                .FirstOrDefault();

            if (topStudent != null)
            {
                Console.WriteLine($"Top Scoring Student: {topStudent.Name} ({topStudent.CalculateAverage():F2})");
            } else
            {
                Console.WriteLine("No students found.");
            }
        }
        public static void ListPeople()
        {
            List<Person> peoples = Person.GetPeoples();

            if (peoples.Count > 0) {
                Console.WriteLine($"Toal Persons Created: {peoples.Count}");
                Console.WriteLine($"Total Students: {peoples.OfType<Student>().Count()}");
                Console.WriteLine($"Total Teachers: {peoples.OfType<Teacher>().Count()}");
                foreach (var p in peoples)
                {
                    p.GetInfo();
                    p.GetType();
                }
            } else
            {
                Console.WriteLine($"There is no one in the list");
            }
        }
    }
}
