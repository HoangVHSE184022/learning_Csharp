using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //RUNTIME TỰ SINH RA GIÚP TA _id, _name, _yob, _gpa LÚC CHẠY APP
        //GIÚP VIẾT CODE TIỆN HƠN, TRÁNH NHỮNG CODE NHÀM CHÁN

        //lỡ quên cú pháp: prop tab

        //java ko có trò này, muốn có phải cài dependency bên ngoài - lombok
    }
}
