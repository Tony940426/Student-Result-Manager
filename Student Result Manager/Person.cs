using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result_Manager
{
    public class Person
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

        public void GetInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }

        public static void ListPeople()
        {
            if (peoples.Count > 0) {
                Console.WriteLine($"There are {peoples.Count}");
                Console.WriteLine("List of People:");
                foreach (var p in peoples)
                {
                    Console.WriteLine($"ID: {p.Id}, Name: {p.Name}");
                }
            } else
            {
                Console.WriteLine($"There is no one in the list");
            }
        }
    }
}
