using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4.Entities
{
    internal class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
