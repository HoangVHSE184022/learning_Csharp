using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5.Entities
{
    internal class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        //ctor + tab: sinh ra constructor rỗng 1 cách chủ động
        public Student()
        {
            
        }


        //Constructor có tham số thì dùng ctrl .
        //n cách để đúc 1 object
        //hoàn thiện 1 object ta dùng set
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
    }
}
