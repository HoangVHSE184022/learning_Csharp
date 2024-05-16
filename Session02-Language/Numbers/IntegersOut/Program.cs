namespace IntegersOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xài hàm out ra sao???
            //có 3 cách
            //c1. Khai báo biến và gán sẵn value nhưng value sẽ bị đè sửa bởi bên trong hàm
            int n = 3979;
            


            //c2. khai báo biến không thèm gán value cho biến vì đằng nào hàm out đã hứa sẽ có value
            int x;
            //Console.WriteLine("Before calling out method, x = " + x);
            ChangeXV2(out x);
            Console.WriteLine("After calling out method, x = " + x);



            //c3. cách này chatgpt, copilot hay dùng
            //vừa khai báo biến, vừa truyền vào out, đằng nào cũng có value từ hàm ném ra!
            ChangeXV2(out int xxx);
            Console.WriteLine("After calling out method, xxx = " + xxx);
        }



        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    ChangeXV1(x); //gọi hàm để xem biến có đổi không
        //    Console.WriteLine("After calling method, x = " + x);
        //}

        //VIẾT 1 HÀM NHẬN VÀO 1 CON SỐ (QUA BIẾN ĐÂU VÀO), SAU ĐÓ HÀM THAY ĐỔI BIẾN ĐẦU VÀO NÀY THÀNH GIÁ TRỊ MỚI
        //KỸ THUẬT TRUYỀN THỐNG: TRUYỀN THAM TRỊ, PASS BY VALUE
        //COPY DÂT TỪ VỊ TRÍ GỐC SANG HÀM ĐƯỢC GỌI
        //HÀM LÀM GÌ KHÔNG BIẾT, DATA GỐC KHÔNG BỊ THAY ĐỔI
        //PASS BY VALUE: TAO CHO MÀY BẢN COPY DATA, PHÔT RA BẢN MỚI
        static void ChangeXV1(int n)
        {
            Console.WriteLine("In method, n at first: " + n);
            n = 3979;
            Console.WriteLine("In method, n after: " + n);
        }

        //C1: VIẾT 1 HÀM TRẢ VỀ 
        //TỔNG CÁC SỐ TỪ 1 - 10 (100)
        //TỔNG CÁC SỐ LẺ TỪ 1 - 10
        //TỔNG CÁC SỐ CHẴN TỪ 1 - 10
        //SỐ LƯỢNG CÁC SỐ LẺ TỪ 1 - 10
        //SỐ LƯỢNG CÁC SỐ CHẴN TỪ 1 - 10
        //SỐ LƯỢNG CÁC SỐ NGUYÊN TỐ TỪ 1 - 10
        //...
        //CHỈ 1 HÀM DUY NHÂT!!!


        //xài hàm cần biến đưa vào
        //              int xx = 20;
        //ChangXV2(out xxx)
        static void ChangeXV2(out int n) 
        {
            //chữ out: hứa trong hàm sẽ có 1 value cho n!!! Phải gám 1 giá trị cho n; ko báo lỗi - giữ lời hứa luôn có 1 value nào đó!!!
            n = 6789;
        }
    }
}
