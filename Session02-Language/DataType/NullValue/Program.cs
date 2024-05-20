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
            CreateStudentObject();
            PlayWithNullable();
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