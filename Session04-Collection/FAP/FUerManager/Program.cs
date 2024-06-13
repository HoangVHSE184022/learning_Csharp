using FUerManager.Entities;
using FUerManager.Services;

namespace FUerManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentCabinet tuSE = new StudentCabinet(30);
            tuSE.AddAStudent(new Student() { Id = "SE1", Name = "AN" });
            tuSE.AddAStudent(new Student() { Id = "SE2", Name = "BINH" });
            tuSE.PrintStudentList();

            //mua cái tủ đựng hồ sơ gv
            LecturerCabinet tuLecturer = new LecturerCabinet(10);
            tuLecturer.AddALecturer(new Lecturer() { Id = "00012345", Name = "AN", Salary = 20000000});
            tuLecturer.AddALecturer(new Lecturer() { Id = "00012346", Name = "AN", Salary = 20_000_000 });
            //_ dùng để phân tách phần ngàn trong code cho dễ đọc code
            //java y chang
            //swp391: khi in bikk, payment, tổng tiền thanh toán phải format

            tuLecturer.PrintLecturerList();
        }
    }
}