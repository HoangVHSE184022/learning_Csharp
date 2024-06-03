using ArrayStudent.Entities;
using System.Net;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentList();
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
            arr[1] = new Student() { Id = "SE2", Name = "Bình", Yob = 2003, Gpa = 8.4 };
            arr[2] = new Student() { Id = "SE3", Name = "Cường", Yob = 2002, Gpa = 7.2 };
            arr[3] = new Student() { Id = "SE4", Name = "Dũng", Yob = 2004, Gpa = 5.6 };
            arr[4] = new Student() { Id = "SE5", Name = "Giang", Yob = 2005, Gpa = 9.0 };
            arr[5] = new Student() { Id = "SE6", Name = "Hưng", Yob = 2002, Gpa = 4.9 };
            arr[6] = new Student() { Id = "SE7", Name = "Khánh", Yob = 2004, Gpa = 5.3 };
            arr[7] = new Student() { Id = "SE8", Name = "Lâm", Yob = 2003, Gpa = 7.9 };
            arr[8] = new Student() { Id = "SE9", Name = "Minh", Yob = 2005, Gpa = 8.9 };
            arr[9] = new Student() { Id = "SE10", Name = "Nam", Yob = 2002, Gpa = 7.6 };
            arr[10] = new Student() { Id = "SE11", Name = "Oanh", Yob = 2005, Gpa = 9.2 };
            arr[11] = new Student() { Id = "SE12", Name = "Phương", Yob = 2004, Gpa = 9.9 };
            arr[12] = new Student() { Id = "SE13", Name = "Quỳnh", Yob = 2003, Gpa = 5.8 };
            arr[13] = new Student() { Id = "SE14", Name = "Sơn", Yob = 2002, Gpa = 6.8 };
            arr[14] = new Student() { Id = "SE15", Name = "Tùng", Yob = 2005, Gpa = 8.1 };

            Console.WriteLine("List of Students ordered by Id");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                    arr[i].ShowProfile();
            }
            Console.WriteLine();

            Console.WriteLine("List of Student ordered by GPA");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] != null && arr[j + 1] != null && arr[j].Gpa > arr[j + 1].Gpa)
                    {
                        Student temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                    arr[i].ShowProfile();
            }

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
