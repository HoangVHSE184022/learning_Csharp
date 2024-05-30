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

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
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

        public string GetId()
        {
            return _id;
        }
        public void SetId(string id)
        {
            _id = id;
        }

        public string GetName() => _name;
        
        public void SetName(string name) => _name = name;
        
        public int GetYob() => _yob;

        public void SetYob(int yob) => _yob = yob;
        
        public double GetGpa() => _gpa;

        public void SetGpa(double gpa) => _gpa = gpa;

        public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";

        public void ShowProfile() => Console.WriteLine($"Id: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}");

    }
}

//CÔNG THỨC LẬP TRÌNH OOP - OBJECT ORIENTED PARADIGM/PROGRAMMING
//LẬP TRÌNH DỰA TRÊN LÀM VIỆC VỚI CÁC OBJECT
//OBJECT LÀ GÌ?
//LÀ NHỮNG THỨ CỤ THỂ QUANH TA MÀ MÔ TẢ DÀI BẰNG NHỮNG CÂU TỪ DÀI
//MÔ TẢ QUA 2 THỨ, 2 GÓC NHÌN
//1. GÓC NHÌN TĨNH - STATE - VỀ ĐẶC ĐIỂM
//      ID, NAME, YOB, GPA, SALARY, WORKING HOURS,...
//2. GÓC NHÌN ĐỘNG - BEHAVIOR - METHOD - FUCTION
//      TÍNH LƯƠNG(), TÍNH SỐ NGÀY NGHỈ CÒN LẠI(), TÍNH TUỔI(), TÍNH BILL(),...

//========> CÔNG THỨC LẬP TRÌNH OOP
//1. NHẬN DIỆN XUNG QUANH BÀI TOÁN CÁC OBJECT (ĐẶC ĐIỂM VÀ HÀNH VI)
//2. PHÂN LOẠI, GOM NHÓM, CHIA NHÓM, ĐẶT TÊN CHO NHÓM THEO NHỮNG OBJECT MÀ CÓ NHIỀU ĐIỂM TƯƠNG ĐỒNG (CLASSIFY - CHIA NHÓM THÀNH CÁC NHÓM - CLASS)
//NHÓM CLASS STUDENT, LECTURER, DOG, CAT,...
//TẠO CLASS (ĐẠI DIỆN CHO 1 ĐÁM OBJECT)
//      ĐẶC ĐIỂM ID:__________
//              NAME:_________
//              YOB:__________
//CLASS NHƯ 1 TEMPLATE, FORM, BIỂU MẪU, BLUE-PRINT, KHUÔN DÙNG ĐỂ ĐÚC, CLONE RA, COPY RA, NHÂN BẢN RA CÁC OBJECT

//3. MỖI FORM, MỖI BIỂU MẪU, MỖI KHUÔN CẦN ĐƯỢC LÔI RA, CLONE, ĐỔ MỰC, VẬT LIỆU ĐIỀN INFO LÊN ĐỂ THÀNH OBJECT. HÀNH ĐỘNG NÀY ỨNG VỚI HÀM CONSTRUCTOR
//  ỨNG VỚI HĐONG LẤY MỰC ĐIỀN VÀO FORM
//  TA TẠO CONSTRUCTOR: ĐỔ INFO VÀO OBJECT

//4. KHI TA ĐIỀN XONG CÁI FORM, BÀI THI TRẮC NGHIỆM, CẦM LÊN
//      TA DÒM NÓ, THẤY NÓ, NHÌN THẤY NÓ -> GET() VIEW() SEE()
//      TA THẤY CÓ ĐÁP ÁN LỖI, TA GÔM/TẨY, SỬA -> SET() SETTING() SETTER()

//5. KHI TA TẠO XONG 1 ACCOUNT TRÊN MXH, TA SẼ SHOW HÊT THÔNG TIN INFO CÓ THỂ
//  KHI XUẤT XƯỞNG CON ĐTH, SẼ KÈM HDSD VÀ THÔNG TIN CẤU HÌNH VÀ TRONG HỘP
//KHOE INFO CỦA 1 OBJECT -> SHOWPROFILE() TOSTRING() - IN HẾT THÔNG TIN RA

// VẬY LẬP TRÌNH OOP LÀ TẠO CLASS, LẬP TRÌNH TRÊN TEMPLATE, FORM CHUNG CHUNG NHÂT
//Y CHANG GIẢI PHƯƠNG TRÌNH BẬC 2 TRÊN A B C, SAU NÀY ĐƯA DATA CỤ THỂ

//TỪ OBJECT RA ĐƯỢC CLASS => TỪ CLASS TRỞ LẠI OBJECT CÙNG NHÓM => KỸ THUẬT QUẢN LÍ INFO QUA OOP

//6. CLONE OBJECT TỪ KHUÔN, NEW OBJECT, NEW CÁI FORM, NEW BỨC TƯỢNG TỪ KHUÔN
//TOÁN TỬ NEW GIỐNG PHOTOCOPY 1 CÁI FORM, ĐIỀN INFO VÀO RIÊNG CỦA MÌNH - OBJECT