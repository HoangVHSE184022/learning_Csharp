namespace IntegersRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6868;
            ChangeX(ref x);
            Console.WriteLine(x);
        }


        static void ChangeX(ref int p)
        {

        }


    }
}



// IN OUT REF: DÍNH ĐẾN THAM SỐ ĐẦU VÀO
// OUT VÀ REF GIỐNG NHAU 99%
// TRONG HÀM THAY ĐỔI THÌ BÊN NGOÀI BỊ ĐỔI THEO - TRUYỀN THAM CHIẾU - PAS BY REFERENCE

//OUT: hứa chắc chắn phải có giá trị trả về
//REF: không hứa, có thể có hoặc không
//xài ref bắt buộc phải gán 1 default value phòng hờ ref không làm gì
//thì sau gọi hàm vẫn có value

//DÙNG OUT TIỆN LỢI HƠN, TỰ NHIÊN HƠN DO LUÔN HỨA TRẢ VỀ GIÁ TRỊ VÀ KHÔNG CẦN GÁN GIÁ TRỊ KHỞI ĐẦU CHO BIẾN HỨNG VALUE
//HÀM LUÔN PHẢI TRẢ VALUE THÌ MỚI HỢP LOGIC