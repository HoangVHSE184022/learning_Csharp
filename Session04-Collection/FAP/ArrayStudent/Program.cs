using ArrayStudent.Entities;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudent();
        }

        //CHALLENGE 2: HÃY LƯU THÔNG TIN HỒ SƠ CỦA 30 BẠN SV
        //GIẢI PHÁP 1:
        //CHƠI NGOO: KHAI BÁO 30 BIÊN STUDENT
        //GIẢI PHÁP 2:
        //CHƠI HIỆN ĐẠI: KHAI BÁO MẢNG

        static void PlayWithStudentList()
        {
            Student[] arr = new Student[30];
            //arr là từng biến sv lẻ nay về ở chung vùng ram bị biến arr quản lí
            //lợi: for nhanh tất cả các biến
            //không chơi mảng thì phải gọi tên từng biến

            arr[0] = new Student() { Id = "SE1", Name = "An", Yob = 2004, Gpa = 8.6 };
            arr[1] = new Student() { Id = "SE2", Name = "Bình", Yob = 2004, Gpa = 8.6 };
            arr[2] = new Student() { Id = "SE3", Name = "Cường", Yob = 2004, Gpa = 8.6 };
            
            //BTVN: hãy lưu thêm 5-10 sv với điểm lộn xộn thứ tự
            //in ra ds sv
            //sắp xếp dsach sv theo gpa tăng dần và in ra màn hình
            
        }

        static void CreateStudent()
        {
            Student s1 = new Student(); //default constructor
                                        //default backing field
            s1.Id = "SE1"; //hàm set()
            s1.Name = "An";
            s1.ShowProfile();

            Student s2 = new Student() { Id = "SE2", Name = "Bình", Yob = 2004, Gpa = 8.6 };
            s2.ShowProfile();
        }
    }
}
