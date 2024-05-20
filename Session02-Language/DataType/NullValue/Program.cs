namespace NullValue
{
    internal class Student
    {
        //c# gợi ý cách viết code phần cơ bản của 1 class cực nhanh gọn, học sau
        //Quay lại truyền thống
        //Class gồm: field + hàm/method => members thành viên của 1 class
        //Encapsulation
        private string _id; //con lạc đà và gạch chân từ đầu tiên
        private string _name;
        private int _yob;  
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"ID: {_id} | Name: {_name} | YoB: {_yob} | GPA: {_gpa}");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentObject();
            
        }

        static void CreateStudentObject()
        {
            //tạo mới hồ sơ sinh viên  - tạo mới object từ template/class Student
            //có khuôn - class ta clone clone

            Student s3 = new Student("SE1", "An", 2004, 7.9);
            s3.ShowProfile();

            Student s1;                 //XIN RAM MÀ THÔI
            //s1.ShowProfile();           //VÙNG NÀY CHỨA RÁC - GARBAGE VALUE
                                        //RÁC ON/OFF CỦA APP TRƯỚC ĐỂ LẠI
            //khai báo biến trong java và C# nếu khai báo biến và không gán value thì cấm không được xài ở các câu lệnh phía dưới
            //dù biến là int, long, floaf, double, chả hat Sydent, Lecture, Pet, Dog,...

            int currentYear;
            //Console.WriteLine(currentYear); //bị chửi vì biến trong ram đang chứa rác - in rác thì có ý nghĩa gì??? nhưng C in ra rác luôn

            currentYear = 2024;
            Console.WriteLine("CurrentYear: " + currentYear);
            //khai báo biến xong phải gán value cho biến (chấp loại biến nào primitive với object)

            Student s2 = null; //xin ram và dọn dẹp ram sạch sẽ, trỏ vào vùng null (byte đầu tiên của ram, đáy ram, tầng trệt của căn hộ)
            //s2.ShowProfile(); //bị chửi lúc run app - runtime
        }
    }
}


//MỘT NAMESPACE CÓ THỂ CHỨ NHIỀU CLASS
//CÁC CLASS NÀY CÓ THỂ NẰM RIÊNG BIỆT TRÊN MỖI TẬP TIN HOẶC NÓI CÁCH KHÁC, MỖI TẬP TIN ỨNG VỚI 1 CLASS CODE

//NHƯNG TRONG 1 TẬP TIN VẪN CÓ THỂ CÓ NHIỀU CLASS NHƯNG XÀI CHUNG 1 TẬP TIN VLAF 1 TÊN GÌ ĐÓ.CS

//LÀM LẺ: MỖI TẬP TIN 1 CLASS -> THƯ MỤC NAMESPACE HOÀNH TRÁNG NHƯNG CLASS NÀO RA CLASS ĐẤY VÌ CHÚNG CÓ TÊN RIÊNG

//LÀM GỘP: 1 TẬP TIN VẬT LÝ CÓ THỂ GỒN NHIỀU CLASSS BÊN TRONG -> THƯ MỤC NAMESPACE GỌN GÀNG NHƯNG KHÔNG BIẾT CHÍNH XÁC CÓ BAO NHIÊU CLASS VÌ CÁC CLASS DÙNG CHUNG 1 TẬP TIN

//THƯỜNG KHÔNG CÓ GÌ ĐẶC BIỆT THÌ MỖI CLASS 1 TẬP TIN VÀ SHARE CHUNG THƯ MỤC CHỨA CODE - SHARE CHUNG NAMESPACE