using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManagerGeneric.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public Lecturer()
        {
            
        }

        public Lecturer(string id, string name, int yob, double salary)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Salary = salary;
        }

        public override string ToString() => $"Id: {Id} | Name: {Name} | Yob: {Yob} | Salary: {Salary}";

        public void ShowProfile() => Console.WriteLine(ToString());
    }
}
