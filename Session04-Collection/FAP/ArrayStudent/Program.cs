using ArrayStudent.Entities;
using System.Net;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentListV2();
        }

        //CHALLENGE 2: HÃY LƯU THÔNG TIN HỒ SƠ CỦA 30 BẠN SV
        //GIẢI PHÁP 1:
        //CHƠI NGOO: KHAI BÁO 30 BIÊN STUDENT
        //GIẢI PHÁP 2:
        //CHƠI HIỆN ĐẠI: KHAI BÁO MẢNG
        static void PlayWithStudentListV2()
        {
            Student[] arr = new Student[30];
            // má mì có nhiều biến Student
            // s1,s2,s3,s4,s5. Chưa có hồ sơ thực sự !!!
            //mảng primitive: arr[0] = 5;!!!
            //mảng object arr[0] là 1 sinh viên, trỏ vùng new Student()
            //           arr[0] = new Student(...){...};

            arr[0] = new Student() { Id = "SE1", Name = "AN" }; //object initializer
            arr[1] = new Student() { Id = "SE2", Name = "BINH", Yob = 2004 };
            arr[2] = new Student() { Id = "SE3", Name = "CUONG" };
            arr[3] = new Student() { Id = "SE4", Name = "DUNG", Yob = 2004, Gpa = 8.6 };
            //In cho tui 2 mảng sv theo 2 cách for
            Console.WriteLine("Show list with for i");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].ShowProfile();
            }
            Console.WriteLine("Show list for each");
            foreach (Student x in arr)
            {
                if (x != null)
                {
                    x.ShowProfile();
                }
                //Không hay vì phải for đến cuối cho phần null
                //phí CPU khi chạy 6 cuối mà không in được
            }
        }
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

//MẢNG PRIMITIVE CHỈ CÓ 2 TẦNG RAM
//TẦNG 1 LÀ BIẾN MÁ MÌ
//TẦNG 2 LÀ DÃY BIẾN TRONG MẢNG [0], [1], [2], ...
//NẾU MẢNG KHÔNG ĐƯỢC GÁN HẾT VALUE CHO CÁC PHẦN TỬ, CÁC BIẾN THỨ i THÌ BIẾN MANG GIÁ TRỊ DEFAULT
//SỐ LÀ 0, BOOL LÀ FALSE - IN THOẢI MÁI LẪN LỘN GIỮA GIÁ TRỊ THẬT VÀ GIÁ TRỊ DEFAULT


//MẢNG OBJECT CÓ 3 TẦNG RAM
//TẦNG 1 LÀ BIẾN MÁ MÌ
//TẦNG 2 LÀ DÃY BIẾN TRONG MẢNG VÀ LÀ BIẾN OBJECT ĐANG CHỜ ĐỂ TRỎ TIẾP VÙNG NEW STUDENT() THẬT SỰ
//[0] [1] [2] ĐANG CHỜ = NEW STUDENT()
//NẾU CHƯA GÁN HẾT MẢNG THÌ BIẾN THỨ [i] CŨNG MANG GIÁ TRỊ DEFAULT, DEFAULT CỦA BIẾN OBJECT LÀ NULL
//RẤT NGUY HIỂM NẾU FOR HẾT MẢNG MÀ MẢNG CHƯA ĐẦY THÌ GẶP NULL THÌ SẼ BỊ REFERENCE EXCEPTION

//KO NÊN FOR HẾT MẢNG DÙ MẢNG LÀ PRIMITIVE HAY OBJECT DO PHẦN CHƯA GÁN LÀ DEFAULT, ĐẶC BIỆT MẢNG OBJECT COI CHỪNG EXCEPTION

//ĐỂ IN MẢNG CÓ 2 CÁCH
//CÁCH 1: FOR ĐẾN CHỖ ĐÃ CÓ VALUE

//CÁCH 2: CỨ FOR HẾT VỚI MẢNG OBJECT, NHƯNG KIỂM TRA IF([i] == NULL) HAY KHÔNG DỂ GỌI HÀM VÙNG NEW

//CÁCH 1 TỐT HƠN DO KHÔNG CẦN FOR PHÍ Ở ĐOẠN CUỐI
//KHI CHƠI MẢNG, TA CẦN THÊM 1 BIẾN PHỤ COUNT, COUNT BAN ĐẦU = 0, CỨ GÁN XONG 1 VALUE CHO BIẾN THÌ CỘNG NGAY: COUNT++


//count = 0, [0] = ...
//count++ [1].....


//Chốt hạ về dấu chấm
//Tên mảng, má mì chấm thì xổ ra length(không care loại mảng)

//Mảng primitive thì, [i]. là vô nghĩa vì biến  primitive [i] có value luôn mà dùng rồi

//Mảng object thì phần tử [i]. xổ ra các method, property của object, của vùng new()
