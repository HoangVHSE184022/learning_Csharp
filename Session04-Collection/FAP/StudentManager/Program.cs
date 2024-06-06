using StudentManager.Services;
using StudentManager.Entities;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //đi mua cái tủ đựng hồ sơ
            Cabinet tuSE = new Cabinet();   //Có sẵn ngăn 30 tủ đựng hồ sơ
                                            //Đang empty _count = 0
            Cabinet tuBiz = new Cabinet();  //có thêm 30 ngăn khác, empty = 0
            //2 vùng new riêng biệt, 2 tủ riêng biệt

            tuSE.AddAStudent(new Student() { Id = "SE1", Name = "An"});
            tuSE.AddAStudent(new Student() { Id = "SE2", Name = "Bình" });
            tuSE.AddAStudent(new Student() { Id = "SE3", Name = "Cường" });
            tuSE.AddAStudent(new Student() { Id = "SE4", Name = "Dũng" });

            tuBiz.AddAStudent(new Student() { Id = "Biz1", Name = "Dũng" });

            //in tủ
            tuSE.PrintStudentList();
            tuBiz.PrintStudentList();
        }
    }
}

//BTVN - ASS2 LMS 
//DEADLINE: 10/6 TRƯỚC 15H00

//Viêt thêm bên Main cái menu in ra 
//1. Thêm mới: nhập từ bàn phím, nhớ convert từ chữ sang số kiểu Integer.parseInt()
//2. In
//3. Xóa sửa gì đó (ko bắt buộc)

//viết thêm cái tủ đựng hồ sơ giảng viên (id, name, yob, salary) - class giảng viên - class tủ đựng gv
