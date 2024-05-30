using StudentManagerV5.Entities;
using System;

namespace StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("s1 at first (default): ");
            Console.WriteLine(s1); //gọi thầm tên em - toString();

            s1.SetName("An");
            s1.SetId("SE1");

            Console.WriteLine("s1 after setting: ");
            Console.WriteLine(s1); //gọi thầm tên em - toString();

            //new đủ
            Student s2 = new("SE2", "Bình", 2004, 8.6);
            Console.WriteLine("s2 full: ");
            Console.WriteLine(s2); //gọi thầm tên em - toString();

            //new đủ nhưng
            var s3 = new Student(name: "Cường", yob: 2005, gpa: 8.7,id: "SE3");
            //kỹ thuật truyền value vào hàm, vào constructor nhưng ko theo thứ tự khai báo biến của tên hàm
            //mà đảo thứ tự value hàm thoải mái, miễn là ghi chú thêm tên biến đầu vào
            //giúp bạn truyền tham số theo cách bạn muốn, thứ tự bạn muốn mà ko gây báo lỗi tương thích tham số
            //kỹ thuật này gọi là: NAMED ARGUMENT: TRUYỀN THAM SỐ ĐI KÈM TÊN THAM SÓ

            //OBJECT VÔ DANH, ANONYMOUS OBJECT
            //Student s4 = new("SE4", "Dũng", 2004, 8.9);
            //  tên biến            object
            //  nickname
            //  con trỏ     trỏ=    vùng new bự
            //s4. tức là vào vùng new xem có public gì
            //s4 chính là tay cầm móc vào con diều (vùng new)
            new Student("SE4", "Dũng", 2004, 8.9).ShowProfile();
            //OBJECT ĐC TẠO RA NHƯNG KO BỊ BIẾN NÀO TRỎ VÀO
            //NHƯ CON DIỀU BAY LÊN RỒI ĐỨT DÂY, KO NÍU NÓ LẠI ĐC ĐỂ ĐIỀU CHỈNH
            //OBJECT MÀ KO ĐC ĐẶT TÊN, GẮN BIẾN TRỎ, GỌI LÀ OBJECT VÔ DANH: ANONYMOUS OBJECT
            //MÁY ẢO JAVA, .NET RUNTIME ĐỊNH KỲ QUÉT VÙNG RAM XEM CÓ ĐỨA NÀO TRÔI NỔI, KHÔNG CÓ CON TRỎ MÓC VÀO, THÌ BỊ CLEAR KHỎI RAM
            //ĐOẠN CODE CỦA RUNTIME TRONG RAM DỌN DẸP BỘ NHỚ GỌI LÀ GABAGE COLLECTOR - BỘ GOM RÁC


            Student s5 = s2; //SE2 | Bình | 8.6

            PassAStudent(s2);
            Console.WriteLine("s2 after calling method:");
            s2.ShowProfile();

        }

        //HÀM KHÁC NGOÀI MAIN() NHƯNG TRONG CLASS
        static void PassAStudent(Student x) //PassX(int x) PassX(out int x)
        {
            x.SetName("THÍCH TỰ DO");
        }
    }
}

//TRUYỀN 1 OBJECT VAOFHAMF CHÍNH LÀ TRUYỀN VÙNG NEW BÊN NGOÀI VÀO HÀM
//CHÍNH LÀ TRUYỀN THAM CHIẾU, VÌ TRONG HÀM MÀ SET() GÌ THÌ VÙNG NEW BÊN NGOÀI BỊ ẢNH HƯỞNG NGAY
//HÀM NHẬN VÀO BIẾN OBJECT CHÍNH LÀ TRUYỀN THAM CHIẾU LUÔN RỒI, TRONG HÀM CÓ THỂ THAY ĐỔI VÙNG NEW BÊN NGOÀI - KHÔNG CẦN REF OUT