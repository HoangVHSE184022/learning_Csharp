using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới hồ sơ sinh viên, 1 bạn cụ thể nào đó
            Student s1 = new Student("SE1", "An", 2004, 9.0);
            s1.ShowProfile();
            //  biến    : object, con người cụ thể
            //  tên gọi : được gọi tắt là s1 và hắn là Student

            String msg = s1.ToString();
            Console.WriteLine("s1 details: " + msg);
            Console.WriteLine("s1 details: " + s1.ToString());
            Console.WriteLine("s1 details: " + s1); //gọi thầm tên em - y chang java

            //NẾU GHÉP TÊN BIẾN VÀO CHUỖI THÌ BIẾN OBJECT SẼ TỰ ĐỘNG GỌI HÀM toString ĐỂ LẤY CHUỖI RA BÊN TRONG OBJECT

            //ĐIỀU GÌ SẼ XẢY RA NẾU TA KHÔNG THÈM LÀM HÀM toString???

            //CÁCH TẠO OBJECT #2
            Student s2 = new("SE2", "Bình", 2004, 8.7);
            s2.ShowProfile();
            Console.WriteLine(s2);

            //CÁCH #3
            var s3 = new Student("SE3", "Cường", 2004, 8.8); //type inferent
            s3.ShowProfile();

            //CÁCH #4
            var s4 = s3; //2 chàng trỏ 1 nàng
            //không có new => không có vùng nhớ mới
            Console.WriteLine("s4 check var!!!");
            s4.ShowProfile();
            s4.SetGpa(999);
            Console.WriteLine("s3 check var after modification");
            s3.ShowProfile();

            //Lưu ý: nếu bạn có 1 biến nhận vào biến object
            //void F(Student x)
            //{
            //}
            //gọi hàm F(s4) ~~~~~~~~ x = s4 trong hàm
            //trong thân hàm x làm gì, thì ngoài hàm lãnh đủ do truyền dữ liệu kiểu object
            //do đó hàm nhận vào biến object chính là đã truyền tham chiếu do trong hàm và ngoài hàm cùng trỏ 1 vùng ram new

        }
    }
}
