using FUerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Services
{

    //void F(int size) {...}
    //int là dât type, kiểu dl, oại dữ liệu, hình dáng của thông tin: int: 1 con số nguyên (the whole number - nguyên consoos không lẻ miếng nào)
    //hàm F() cần 1 con số nguyên  nào đó
    //void F(int size)
    //size là dât, dữ liệu cụ thể nào đó, 1 con số nào đó bất kỳ miễn là nguyên
    //void F(int size)
    //int: cố định, hàm chơi số nguyên
    //size: thay đổi, value, con số nguyên cụ thể

    //TRUYỀN THỐNG: HÀM NHẬN VÀO THAM SỐ, NGHĨA LÀ DÂT TYPE CỐ ĐỊNH, VALUE CỦA DATA TYPE THÌ THAY ĐỔI
    //TRUYỀN THỐNG: TRUYỀN THAM SỐ CHÍNH LÀ TRUYỀN 1 "VALUE" (THAM TRỊ/THAM CHIẾU)

    //HIỆN ĐẠI: DATA TYPE ĐC QUYỀN THAY ĐỔI, GIỐNG NHƯ THAM SỐ CỦA HÀM
    //HÀM BÂY GIỜ CHẤP NHẬN ĐẦU VÀO CÓ 2 SỰ THAY ĐỔI
    //      VOID F(??? BIẾN)
    //              ??? CÓ THỂ LÀ BẤT KỲ 1 DATA TYPE NÀO: STUDENT, LECTURER,...
    //sau khi xđ đc data type, ta mới xác định tiếp giá trị của biến thuộc data type đó

    //VOID F(Student BIẾN)
    //VOID F(Student BIẾN)
    //KỸ THUEETSJ TRUYỀN VÀO 1 DATA TYPE, DATA TYPE ĐC TRUYỀN VÀO 1 HÀM, 1 CLASSS (ĐỂ XĐ CLASS SẼ LÀM VIỆC VỚI DATA TYPE NÀO
    //DATA TYPE LÀ THAM SỐ LUÔN => KỸ THUẬT NÀY ĐC GỌI LÀ GENERIC
    //XÀI KÍ TỰ <DATA TYPE MUỐN TRUYỀN VÀO CLASS, HÀM> KHIẾN CHO HÀM VÀ CLASS CÓ THỂ CHƠI DC VỚI NHIỀU LOẠI DATA TYPE

    //GENERIC REPOSITORY & UNIT OF WORK

    public class StudentCabinet
    {
        //private Student[] _arr = new Student[30];
        private Student[] _arr;
        private int _count = 0;
        //Chưa có biến nào trong mảng được gán value. Sau này for thì chỉ for đến _count tránh Null Reference Exception

        //Đóng tủ mà có kích thước theo yêu cầu
        public StudentCabinet(int size)
        {
            _arr = new Student[size];
        }

        //crud method
        public void AddAStudent(Student s) => _arr[_count++] = s;

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