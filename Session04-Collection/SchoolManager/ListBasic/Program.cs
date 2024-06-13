using ListBasic.Entities;
using System.Collections;

namespace ListBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithArrayList();
        }

        static void PlayWithList()
        {
            List<Student> arr = new List<Student>();
            //Java: List<Student> arr = new ArrayList<>();
            //Java: ArrayList<Student> arr = new ArrayList<>();

            arr.Add(new Student() { Id = "SE1", Name = "An", Yob = 2004, Gpa = 8.6 });
            arr.Add(new Student() { Id = "SE2", Name = "Bình", Yob = 2003, Gpa = 8.4 });
            arr.Add(new Student() { Id = "SE3", Name = "Cường", Yob = 2005, Gpa = 8.2 });
            arr.Add(new Student() { Id = "SE4", Name = "Dũng", Yob = 2004, Gpa = 8.5 });

            //4 biến được sinh ra, và 4 biến này trỏ 4 vùng new

            Console.WriteLine("The list of students");
            for (int i = 0; i < arr.Count; i++)
            {
                //arr[i].ShowProfile();
                arr.ElementAt(i).ShowProfile(); //get(i) bên java
            }
        }

        //Java: list (abstract), ArrayList (concrete - cụ thể)
        //      List<Student> arr = new ArrayList<>();
        //      ArrayList<Student> arr = new ArrayList<>();

        //CẤM KHÔNG ĐƯỢC NEW List() vì nếu ngoan cố new List<>() thì sẽ bị đập vào mặt khoảng 20 hàm cần viết code @Override
        //KỸ THUẬT NÀY JAVA GỌI LÀ KUX THUẬT ANONYMOUS CLASS - CLASS ẨN DANH

        //C#: khác
        //ArrayList new ArrayList() KHÔNG CÓ GENERIC!!!!
        //Không nên dùng ArrayList của C#

        //C# KHÁC:
        //List<> là generic
        //VÀ NEW LIST<> NHƯ BÌNH THƯỜNG, TỨC LÀ LIST<> BÊN C# THAY THẾ NGANG BẰNG ARRAYLIST<> BÊN JAVA

        static void PlayWithArrayList()
        {
            ArrayList arr = new ArrayList();
            //ram: 1 vùng new bự dự kiến sẽ có nhiều biến đc nhét vô
            //new ArrayList() = new int[]
            //chừng nào gán value thì mới thêm biến tương ứng

            arr.Add(5); //arr[0] = 5
            arr.Add(10); //arr[1] = 10
            arr.Add(15);
            arr.Add("Hello");  //No type-safe

            //không khuyên dùng vì lộn xộn datatype vì lộn xộn cả object và primitive
            //chưa kể object khác nhau: student, lecturer,... và mỗi object có . riêng của nó

            //for tới bến không cần _count vì không cấp dư cùng ram cho biến trong new

            Console.WriteLine("The list of numbers");
            for (int i = 0; i < arr.Count; i++) //arr.size() bên java
            {
                Console.WriteLine(arr[i]); //arr.get(i) bên java
            }
        }
    }
}
