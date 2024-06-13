using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //làm biếng làm constructor thì xài constructor default + object initializer để fill info
        public Student()
        {
            
        }

        public Student(string id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }

        public override string ToString() => $"Id: {Id} | Name: {Name} | Yob: {Yob} | Gpa: {Gpa}";

        public void ShowProfile() => Console.WriteLine(ToString());
    }
}
