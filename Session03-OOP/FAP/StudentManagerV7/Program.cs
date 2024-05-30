using StudentManagerV7.Entities;

namespace StudentManagerV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới object Student và dùng Get Set như bình thường
            Student s1 = new Student();
            //default cả đám
            Console.WriteLine("s1 default: ");
            s1.ShowProfile();

            s1.Id = "SE1";
            s1.Name = "An";
            s1.Yob = 2004;
            s1.Gpa = 8.6;
            Console.WriteLine("s1 after modifying: ");
            s1.ShowProfile();

            //VIẾT TỰ NHIÊN HƠN SO VỚI s1.SetName("An") 
            //Id, Name, Yob, Gpa được gọi là PROPERTY CỦA 1 OBJECT
            //CÒN _id, _name, _yob, _gpa ĐƯỢC GỌI LÀ BACKING FIELD
            //ĐỨA ĐỨNG SAU, CHỐNG LƯNG CHO PROPERTY, CHO HÀM GET SET

            //CÁCH NEW VI DIỆU BẮT ĐẦU, PHỐI HỢP VỪA NEW, VỪA SET() LUÔN
            Student s2 = new Student() { Id = "SE2", Name = "Bình", Yob = 2004, Gpa = 8.6 };      
            //KỸ THUẬT NEW KIỂU NÀY, NEW XONG RỒI GÁN LUÔN SET()
            //TRÊN CÙNG 1 CÂU LỆNH (ĐỪNG NHẦM VỚI NAMED-ARG - NEW TRONG CONSTRUCTOR
            //GỌI HÀM SET() LÚC NEW - GỌI LÀ OBJECT INITTIALIZER - KỸ THUẬT KHỞI ĐỘNG OBJECT
            Console.WriteLine("s2 full: ");
            s2.ShowProfile();

        }
    }
}
