using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    public class Student
    {
        private String _id;     
        private String _name;   
        private int _yob;       
        private double _gpa;

        //phễu, constructor: đổ data từ ngoài vào trong
        //Ctrl . -> Generate constructor
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }
        public void SetYob(int yob)
        {
            _yob = yob;
        }

        public void SetGpa(double gpa) => _gpa = gpa;

        public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";
        
        //public override string ToString()
        //{
        //    return $"{_id} | {_name} | {_yob} | {_gpa}";
        //}


    }
}
