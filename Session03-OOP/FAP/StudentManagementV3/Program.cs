using StudentManagerV3.Entities;

namespace StudentManagementV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); //xài empty/default constructor - đúng cho java luôn
            Console.WriteLine("s1 detail by using default constructor: ");
            Console.WriteLine(s1);

            //muốn sửa info thì chắc chắn phải là đem nguyên vật liệu về đổ vào - setter, hàm Set()

            //ĐIỀU GÌ XẢY RA NẾU CLASS CỦA BẠN THIẾT KẾ SẴN 1 HAY 1 VÀI CONSTRUCTOR CÓ THAM SỐ???
        }
    }
}
