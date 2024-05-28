using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    internal class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";

        //nếu 1 cái khuôn không làm cái phễu thì ta vẫn đúc được 1 object mang không khí bên trong - mặc nhiên có đc object không khí
        //mặc nhiên có sẵn gọi là default
        //ĐỐI VỚI JAVA C# NẾU BẠN KHÔNG LÀM CONSTRUCTOR/PHỄU ĐỂ ĐÚC OBJECT, THÌ JAVA, C# CUNG CẤP SẴN CHO BẠN 1 PHỄU TRỐNG KHÔNG, KO NHẬN ĐẦU VÀO, CŨNG CHẲNG CÓ XỬ LÝ GÁN ĐỒ RA VÔ, CÁI CONSTRUCTOR DEFAULT
        //DẠNG public Student() {}



    }
}
