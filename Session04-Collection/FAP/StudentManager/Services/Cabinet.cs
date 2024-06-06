using StudentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    //cái tủ là 1 thứ giống cái form, template, khuôn dùng để lưu trữ nhiều info, nhiều món đồ, nhiều object. Info này chính là object
    //ta tạo class tủ để tương lai ta new từng cái tủ
    //đi mua cái tủ đi - new Tủ() - new Cabinet()
    //mua tủ thì có được không gian lưu trữ, cất trữ món đồ, nhiều món đồ
    //để cất trữ nhiều món đồ ta cần mảng
    //ĐẶC TÍNH CỦA CÁI TỦ LÀ CÁI MẢNG - KHÔNG GIAN CHỨA ĐỒ
    //HÀNH ĐỘNG CỦA TỦ: CRUD MÓN ĐỒ
    //CREATE | RETRIEVE/READ | UPDATE | DELETE

    public class Cabinet
    {
        //private Student[] _arr;    //có new ngay hay không new Student[30]
        //tùy

        private Student[] _arr = new Student[30];
        private int _count = 0; //tủ mới mua về thì chưa có món đồ nào
                                //nhưng nếu có thì tối đa 30 hoặc là size

        //GET() SET()
        //KHÔNG CÓ SET CHO BIẾN _COUNT VÌ ẢNH HƯỞNG ĐẾN ĐẾM SỐ OBJECT HỒ SƠ SV TRONG MẢNG - BIẾN NỘI BỘ KO CÓ NHU CẦU GET() SET() RA NGOÀI
        //CÙNG LẮM CÓ THÊM HÀM GET() ĐỂ BIẾT TỦ CÓ BAO NHIÊU ĐỒ

        public int Count => _count; //hàm GET(), không phải biến int Count

        //TA KHÔNG LÀM GET() SET() CHO_ARR TẠI SAO???
        //GET TRẢ VỀ MẢNG THÔ, CÓ SAO TRẢ VỀ VẬY - KHÔNG ỔN VỀ MẶT QUẢN LÝ DATA
        //LẼ RA PHẢI TRẢ VỀ MẢNG ĐÃ SẮP XẾP THEO...
        //VẬY TRẢ VỀ MẢNG QUA XỬ LÍ TÍNH TOÁN -> VẬY PHẢI LÀ 1 HÀM CÓ TÍNH TOÁN, CHỨ KHÔNG PHẢI GET() THUẦN
        //KHÔNG LÀM GET LÀ HỢP LÍ

        //HÀM SET() NGIAWX LÀ PHẢI CHUẨN BỊ 1 MẢNG CÓ 1 SỐ LƯỢNG SV
        //RỒI MOVE NHANH 1 PHÁT VÀO MẢNG
        //arr = mảng đã đủ, nhiều sv
        //ko thực teesL tủ hồ sơ sẽ đc add từ từ
        

        //tạo mới nhiều sp cùng lúc - chuẩn bị 1 danh sách excel - import

        public Cabinet(int size)
        {
            _arr = new Student[size]; //tủ đạt hàng ko gian lưu trữ theo yêu cầu
        }

        public Cabinet()
        {
            
        }

        //bộ hàm crud
        public void AddAStudent()
        {
            //ta phải có code để nhập sv ở đây thì mới new được
            //nhập này: Console.ReadLine() => trả về chuỗi => cần số thì convert từ chuỗi về số
            //Hàm này chỉ chơi với console - KÉM LINH HOẠT vì việc nhập info có thể đến từ web, winform - UI desktop, mobile
            //đảm bảo linh hoạt việc nhập - đừng gắn việc nhập vào class này 
            //class này chỉ lo xử lý info, nhập để nơi khác truyền sang
        }

        public void AddAStudent(string id, string name, int yob, double gpa)
        {
            //có info ở ngoài truyền vào, new student hoi và add vào vị trí thứ [i count] của mảng
        }

        public void AddAStudent(Student s) //tốt nhất
        {
            //có info ở ngoài truyền vào, new student hoi và add vào vị trí thứ [i count] của mảng
            if (_count == 29) {
                Console.WriteLine("The list is full, no more student profile added");
                return;
            } //đã có return trong if thì ko cần else

            _arr[_count] = s; //new Student() {}
            _count++;
        }

        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} Student(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                _arr[i].ShowProfile();
            }
        }

    }
}

//nhiều hàm trùng tên nhưng khác tham số được gọi là overloading
//OVERLOADING được gọi là 1 dạng thể hiện của nguyên lý đa hình - polymorphism