using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result_Manager
{
    public class Person
    {
        private static int idCounter = 1;


        public int id { get; private set; }
        public string name { get; set; }
        //this is the same as private string name
        //public string Name  
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public Person(string name)
        {
            this.id = idCounter++;   
            this.name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }
    }
}
