using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6.Entities
{
    internal class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        //các cặp get set
        public string GetId() => _id;
        public void SetId(string id) => _id = id;

        public string Name //PROPERTY: LAI GIỮA HÀM GET SET VÀ BIẾN THÔNG THƯỜNG string Name
        {                   
            get { return _name; }
            set { _name = value; }
        } //style này lợi dụng rằng khai báo 1 biến chính là đã khai báo luôn 2 thứ get value của biến và set value của biến

        public int GetYob() => _yob;
        public void SetYob(int yob) => _yob = yob;
        public double GetGpa() => _gpa;
        public void SetGpa(double gpa) => _gpa = gpa;
    }
}
