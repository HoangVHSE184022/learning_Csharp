using StudentManagerV2.Entities;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo object khi cái khuôn có đến 2 cái phễu
            Student s1 = new("SE1", "An", 2004, 8.6);
            Console.WriteLine("s1 detail: " + s1);

            Student s2 = new("SE2", "Binh");
            Console.WriteLine("s2 detail: " + s2);
            //NẾU BIẾN CỤC BỘ (BIẾN KHAI BÁO TRONG HÀM) MÀ KHÔNG GÁN GIÁ TRỊ THÌ CẤM SỬ DỤNG Ở CÁC LỆNH TIẾP ĐÓ
            //NẾU FIELD CỦA OBJECT MÀ KHÔNG ĐƯỢC GÁN VALUE LÚC ĐÚC, LÚC NEW THÌ SẼ MANG GIÁ TRỊ DEFAULT
            //SỐ = 0, CHỮ = RỖNG, BOOL = FALSE
            //ĐỂ ĐẢM BẢO CÁC HÀM BÊN TRONG OBJECT VẪN SỬ DỤNG BIẾN ĐƯỢC BÌNH THƯỜNG BÌ ĐÃ CÓ VALUE, DÙ LÀ VALUE DEFAULT

            //ĐỂ SỬA ĐƯỢC NHỮNG VALUE DEFAULT NÀY THÌ TA ĐỔ VALUE MỚI CHO NÓ TỨC LÀ GỌI HÀM SETTER (ĐƯA VÀO DATA MỚI ĐÈ DATA CŨ)
            s2.SetYob(2005);
            s2.SetYob(2006);
            s2.SetYob(2007);
            s2.SetYob(2008);
            Console.WriteLine("s2 after setting yob: " + s2);

            //một vùng new SE2 Binh có thể đc chỉnh sửa thông tin thoải mái số lần
            //NGHĨA LÀ HÀM SET CÓ THỂ GỌI NHIỀU LẦM VÀ VẪN LÀ OBJECT ĐÓ, VẪN VÙNG NEW ĐÓ 

            //NHƯNG
            s2 = new("S22", "HAI HAI");
            Console.WriteLine("s2 after new: " + s2);

            //khi dùng new là lập tức có vùng ram mới
            //new là gọi phễu để đúc ra object mới
            //.Set có thể gọi n lần ứng với việc mình thay đổi background thành hình bạn trai/bạn gái mới và thay đổi background bao nhiêu lần thì vẫn là đth cũ, object cũ
            //Set(): thay đổi trên object
            //new: tạo mới object hoàn toàn
        }
    }
}
