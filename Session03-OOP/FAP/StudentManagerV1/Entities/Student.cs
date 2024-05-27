using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    internal class Student
    {
        //đặc tính của 1 object, đặc điểm của 1 object được gọi là field, attribute, "biến"
        //hành động của 1 object, chính là hàm (hàm là xử lí, hành động)
        //còn gọi là method
        //hàm/method + "biến" field gọi chung là MEMBER, THÀNH VIÊN, THÀNH PHẦN CỦA 1 OBJECT
        private String _id;     //_____________
        private String _name;   //_____________
        private int _yob;       //_____________
        private double _gpa;    //_____________

        public Student(String id, String name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //bộ hàm chỉnh sửa info của 1 object, set, setter
        //chỉnh sửa nghĩa là phải đưa info mới vào, đè vào info cũ
        public void SetId(String id)
        {
            _id = id;
        }

        public void SetName(String name)
        {
            _name = name;
        }

        public void SetYob(int yob)
        {
            _yob = yob;
        }

        public void SetGpa(double gpa) =>_gpa = gpa;
        //expression body, rút gọn tên hàm khi chỉ có 1 lệnh

        public String GetId() => _id;
        public String GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

        public void ShowProfile()
        {
            Console.WriteLine("Here is my profile");
            Console.WriteLine($"ID: {_id}\nName: {_name}\nYoB: {_yob}\nGPA: {_gpa}");
        }

        //@Override
        public override String ToString()
        {
            return $"ID: {_id} | Name: {_name} | YoB: {_yob} | GPA: {_gpa}";
        }


    }
}

//OBJECT - ĐỐI TƯỢNG LÀ 1 THỨ QUANH TA, DÙNG NHIỀU LỜI ĐỂ MÔ TẢ VỀ NÓ: cây bút trên tay có giá tiền, hãng sx, màu sắc,...
//ĐỐI TƯỢNG ĐƯỢC MÔ TẢ QUA ĐẶC ĐIỂM VÀ HÀNH VI - HÀNH ĐỘNG
//bé cưng nhà mình có: tên, năm sinh, đã chích vaccine, hành động: dụi má vào tay, cào ghế nệm,...
//CÁC ĐỐI TƯỢNG ĐỀU ĐƯỢC CHO 1 CÁI TÊN GỌI - DANH TỪ RIÊNG: cái bút của tôi, bé cưng nhà bạn, tôi, bạn, sếp,...
//DANH TỪ RIÊNG: TÊN GỌI CHO 1 ĐỐI TƯỢNG CỤ THỂ NÀO ĐÓ

//CÁC ĐỐI TƯỢNG QUANH TA ĐƯỢC CHIA THÀNH CÁC NHÓM DỰA THEO ĐẶC ĐIỂM CHUNG, ĐIỂM TƯƠNG ĐỒNG. TA GOM CÁC ĐỐI TƯỢNG THÀNH 1 NHÓM, ĐẶT CHO CHÚNG 1 CÁI TÊN - CLASS XUẤT HIỆN
//CLASS LÀ TÊN GỌI CHUNG, DANH TỪ CHUNG CHO 1 NHÓM STUDENT
//Class Student đại diện cho 1 nhóm bạn an, bình, cường, dũng
//Class như cái khuôn dùng để đúc ra các đối tượng
//Student có an bình cường dũng, em, giang, huong,...
//Các đối tượng đều chia sẻ đặc tính: id, name, yob, gpa,...

//TỪ ĐÓI TƯỢNG -> TÌM RA CLASS (NHÓM ĐỐI TƯỢNG) -> CLONE RA OBJECT MỚI
//GIÚP TA QUẢN LÝ MỌI OBJECT, MỌI INFO QUANH TA