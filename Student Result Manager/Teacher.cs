using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result_Manager
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, string subject) : base(name)
        {
            this.Subject = subject;
        }
        public void GetTeacherInfo()
        {
            GetInfo();
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}
