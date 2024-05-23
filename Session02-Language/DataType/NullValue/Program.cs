using Microsoft.VisualBasic;

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


    internal class StudentNull
    {
        //c# gợi ý cách viết code phần cơ bản của 1 class cực nhanh gọn, học sau
        //Quay lại truyền thống
        //Class gồm: field + hàm/method => members thành viên của 1 class
        //Encapsulation
        private string _id; //con lạc đà và gạch chân từ đầu tiên
        private string _name;
        private int _yob;
        private double? _gpa;

        public StudentNull(string id, string name, int yob, double? gpa)
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
            //CreateStudentObject();
            //PlayWithNullable();
            PlayWithNullableV2();
        }

        static void PlayWithNullableV2()
        {
            int a = 0;
            //int b = null; //bị chửi ngay lúc gõ code vì đây là biến primitive (Java) C#: value type
            //là biến, vùng ram chỉ lưu 1 giá trị đơ lẻ nào đó
            //số, ký tự: int, long, float, double
            //biến style đơn giản này phải gán 1 giá trị hợp lệ, không cho null

            int? c = 0; //vẫn int bình thường
            c = null; //nhưng có thể mang giá trị null
            // để match với 1 cột null trong database

            //? ?? y chang như đã học
            Student s1 = null;
            Student? s2 = null;

            //với kiểu dữ liệu class/object 
            //mặc nhiên là đc dùng null mô tả trạng thái tui chưa trỏ ai
            //tui chưa xác định - dùng kq trả về của search

            //Dùng thêm ? cũng chẳng ảnh hưởng
            //? đi kèm data type đc gọi là nullable
            //em có khả năng chưa giá trị null và áp dụng chung cho cả 2 kiểu primitive và object

        }

        //static void PlayWithNullV4()
        //{
        //    Student s1 = null;
        //    Student s2 ??= s1;
        //}

        static void PlayWithNullV3()
        {
            int yob = 2004;
            string msg;
            //Nếu năm sinh > 2000 thì in ra GenZ
            //ngược lại in ra Outdated

            //if (yob > 2000)
            //{
            //    msg = "GenZ";
            //} else
            //{
            //    msg = "Outdated";
            //}

            msg = yob > 2000 ? "GenZ" : "Outdated";
            //TOÁN TỬ TÌNH TAY BA - CODITIONAL TERNARY OPERATOR
            //TOÁN TỬ 3 NGÔI
            //MỆNH ĐỀ ĐÚNG SAI TRONG PHÉP TOÁN NÀY KO HẲN LÀ CHECK NULL MÀ LÀ BẤT KỲ MỆNH ĐỀ SO SÁNH NÀO
            //CHỈ CẦN ĐÚNG SAI, KO CẦN CÓ ĐÚNG NULL KHÔNG
           //CÓ ĐÚNG NULL KHÔNG MÌNH DÙNG ? CŨNG ĐƯỢC HOẶC DÙNG ??
            Console.WriteLine(msg);

            Student s1 = null;
            Student s2 = s1 == null ? new Student("SE2", "Hai", 2002, 2.2) : s1;
            s2.ShowProfile();
        }

        static void PlayWithNullV2()
        {
            Student s1 = null;
            Student s2 = s1; //s2 cũng bằng null luôn

            Student s3 = null;
            Student s4 = s3 ?? new Student("SE4", "Bốn", 2004, 4.4);
            s4.ShowProfile();

            //viết lại thì nó là:
            if (s3 == null)
            {
                s4 = new Student("SE4", "Bốn", 2004, 4.4);
            } else
            {
                s4 = s3;
            }
            //KỸ THUẬT NÀY ĐẢM BẢO RẰNG BIẾN SẼ CÓ GIÁ TRỊ NÀO ĐÓ, ĐƯỢC GÁN GIÁ TRỊ NÀO ĐÓ | ĐỪNG NHẦM VỚI BIẾN?GỌI HÀM - NULL CONDITION
            //KỸ THUẬT NÀY DÙNG ĐỂ GÁN GIÁ TRỊ DEFAULT CHO 1 BIẾN KHI NGỘ NHƠ VẾ BÊN PHẢI CÓ THÀNH PHẦN LÀ NULL THÌ MÌNH CÓ GIÁ TRỊ DỰ PHÒNG
            //TOÁN TỬ NÀY GỌ LÀ COALESING - TOÁN TỬ KẾT NỐI, KÊT HỢP

            Student s5 = new Student("SE5", "Năm", 2005, 5.5); ;
            Student s6= s5 ?? new Student("SE6", "Sáu", 2006, 6.6);
            s6.ShowProfile();
        }

        static void PlayWithNull()
        {
            Student s1;
            //s1.ShowProfile(); //bị chửi vì biến đang lưu rác, không gọi hàm đươc, vì rác thì không có hàm để chạy
            //Java và C# khai báo biến mà không gán giá trị thì cấm không được dùng lệnh dưới đó
            //tệ nhất phải gán null - TRỎ VÀO ĐÁY RAM, BYTE 0
            Student s2 = null;
            //s2.ShowProfile(); //Runtime error
            //để tránh runtime thì ta dùng if, hoặc gán tử tế biến object rồi mới chấm hàm để dùng
            //tại sao có null để phải check: dính đến kết quả search có thể thấy và không thấy object: ko thấy thì trả về null
            if (s2 is null)
            {
                Console.WriteLine("Please assigning or creating an object first before printing s2");
            } else
            {
                s2.ShowProfile();
            }
            //cách viết trên hơi dài 1 tí nhưng ổn

            Student s3 = null;
            Console.WriteLine("s3 checking...");
            s3?.ShowProfile();
            //NULL CONDITION OPERATOR
            //LÀ KÝ HIỆU, PHÉP TOÁN, PHÉP SO SÁNH KIỂM TRA 1 OBJECT CỐ NULL HAY KHÔNG TRƯỚC KHI GỌI HÀM CỦA NÓ
            //VIẾT GỘP CỦA IF VÀ ELSE
            //TRÁNH BỊ RUNTIME ERROR

            Student s4 = new Student("SE4", "Bốn", 2004, 4.0);
            Console.WriteLine("s4 checking...");
            s4?.ShowProfile();
        }

        static void PlayWithNullable() 
        {
            Student s3 = new Student("SE1", "An", 2004, 7.9);
            StudentNull s4 = new StudentNull("SE2", "An", 2004, null);

            s4.ShowProfile();
            //null tại thời điểm này chỉ áp dụng cho biến object 
            //trỏ vào vùng an toàn byte thứ 0
            //mang ý nghĩa chưa có sv nào đó cần quan tâm, tìm thấy khi search
            //không áp dụng cho biến primitive (java)

            //C# offer cho 1 cơ chế: biến primitive null để tương thích null trong database, cột điểm gqa trong database là null
            //trong code double gpa = null????

            double? gpa = 9.0;
            gpa = null;

            //ta có int?, long?, double?, float? char? bool?
            //vẫn mang giá trị như xưa nay và còn được gán thêm giá trị null
            //STYLE NÀY ĐƯỢC GỌI LÀ NULLABLE - CÓ THỂ MANG THÊM GIÁ TRỊ NULL
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
                               //vì trỏ vào vùng new student không có data để show


            //s2 = new Student(...); ổn
            s2 = s3;
            s2.ShowProfile();

            Student s4 = null;

            if (s4 != null) //!= và == để check có đang trỏ null hay không
            {
                s4.ShowProfile();
            } else
            {
                Console.WriteLine("Please create a student profile before printing");
            }

            if (s4 is not null) //is not null và is null - giống SQL
            {
                s4.ShowProfile();
            }
            else
            {
                Console.WriteLine("Please create a student profile before printing");
            }
        }
    }
}

//MẶC ĐỊNH BIẾN OBJECT KHI KHAI BÁO THÌ CÓ QUYỀN GÁN BẰNG NHỮNG GIÁ TRỊ SAU
// = NEW 1 VÙNG OBJECT - GỌI CONSTRUCTOR
// = 1 BIẾN OBJECT ĐÃ NEW TRƯỚC ĐÓ
// = NULL - TRỎ ĐÁY RAM
// DÙNG SEARCH 1 OBJECT VÀ KHÔNG TÌM THẤY THÌ TRẢ VỀ NULL
// CÒN TÌM THẤY THÌ TRẢ VỀ VÙNG NEW STUDENT NÀO ĐÓ


//MỘT NAMESPACE CÓ THỂ CHỨ NHIỀU CLASS
//CÁC CLASS NÀY CÓ THỂ NẰM RIÊNG BIỆT TRÊN MỖI TẬP TIN HOẶC NÓI CÁCH KHÁC, MỖI TẬP TIN ỨNG VỚI 1 CLASS CODE

//NHƯNG TRONG 1 TẬP TIN VẪN CÓ THỂ CÓ NHIỀU CLASS NHƯNG XÀI CHUNG 1 TẬP TIN VLAF 1 TÊN GÌ ĐÓ.CS

//LÀM LẺ: MỖI TẬP TIN 1 CLASS -> THƯ MỤC NAMESPACE HOÀNH TRÁNG NHƯNG CLASS NÀO RA CLASS ĐẤY VÌ CHÚNG CÓ TÊN RIÊNG

//LÀM GỘP: 1 TẬP TIN VẬT LÝ CÓ THỂ GỒN NHIỀU CLASSS BÊN TRONG -> THƯ MỤC NAMESPACE GỌN GÀNG NHƯNG KHÔNG BIẾT CHÍNH XÁC CÓ BAO NHIÊU CLASS VÌ CÁC CLASS DÙNG CHUNG 1 TẬP TIN

//THƯỜNG KHÔNG CÓ GÌ ĐẶC BIỆT THÌ MỖI CLASS 1 TẬP TIN VÀ SHARE CHUNG THƯ MỤC CHỨA CODE - SHARE CHUNG NAMESPACE