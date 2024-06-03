using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStudent.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student() { }

        public Student(string id, string name, int yob, double gpa)
        {

            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }

        public void ShowProfile() => Console.WriteLine($"Id: {Id} | Name: {Name} | Yob: {Yob} |  Gpa: {Gpa}");
        

        public override string? ToString() => $"Id: {Id} | Name: {Name} | Yob: {Yob} |  Gpa: {Gpa}";
        
    }
}
