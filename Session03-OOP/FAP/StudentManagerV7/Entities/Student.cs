using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV7.Entities
{
    internal class Student
    {
        private String _id; //BACKING FIELD
        private String _name; //CHỐNG LƯNG, HẬU TRƯỜNG CHO GET SET STYLE MỚI
        private int _yob;
        private double _gpa;

        public Student()
        {
            
        }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public string Id //PROPERTY
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Yob
        {
            get => _yob; 
            set => _yob = value; 
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //xài GetGpa() thì .Gpa xong - sờ biến chính là Get()
        //xài SetGpa(999) thì .Gpa = 999 - = chính là Set()

        //in thử info object, flex object
        public void ShowProfile()
        {
            Console.WriteLine($"Id : {_id} | Name: {_name} | Yob: {Yob} | Gpa: {Gpa}");
        } //xài biến tưc là xài Get() tiwcs là return _                         _gpa
    }
}
