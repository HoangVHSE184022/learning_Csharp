namespace Integers
{
    internal class Program
    {
        static void Main(string[] args) //svm tab
        {
            Console.WriteLine($"Sum even number from 1 to 10: {SumOdds(10)}");
        }


        //static void Main(string[] args)
        //{
        //    //PrintIntegerList();
        //    //PrintEvenList();
        //    //PrintNumberFrom1ToN(100);
        //    var result = SumEvens(10);
        //    //Console.WriteLine("Sum even number from 1 to 10: " + result);
        //    //Console.WriteLine("Sum even number from 1 to 10: {0}", result);
        //    //Console.WriteLine($"Sum even number from 1 to 10: {result}");
        //    //Console.WriteLine($"Sum even number from 1 to 10: {SumEvens(10)}");
        //    //Console.WriteLine($@"Căn bậc 2 của 100: {Math.Sqrt(100)}");

        //    //string msg = $@"Căn bậc 2 của 100: {Math.Sqrt(100)}";
        //    //Console.WriteLine(msg);
        //}

        //C# hỗ trợ các kiểu dữ liệu số nguyên y chang Java: int, long,...
        //C# cũng hỗ trợ các cấu trúc câu lệnh y chang Java: if, if-else, switch, do-while, while

        //CHALLENGE 1: Hãy viết 1 hàm in ra các số tự nhiên từ 1 đến 100
        static void PrintIntegerList()
        {
            Console.WriteLine("The list of numbers from 1 to 100");
            int i = 0;
            do
            {
                i++;
                //Console.Write(i + " ");
                //Console.Write("{0} ", i);
                Console.Write($"{i}\t");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            } while (i < 100);
            Console.WriteLine();
        }

        //C2: VIẾT HÀM IN RA CÁC SỐ CHẴN TỪ 1 ĐẾN 100
        static void PrintEvenList()
        {
            Console.WriteLine("The list of even numbers from 1 to 100");
            int i = 0;
            do
            {
                i++;
                if (i % 2 == 0)
                {
                    //Console.Write(i + " ");
                    //Console.Write("{0} ", i);
                    Console.Write($"{i}\t");
                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                
            } while (i < 100);
            Console.WriteLine();
        }


        //C3: VIẾT HÀM IN RA CÁC SỐ TỪ 1 ĐẾN N
        // bữa sau: VAR, OUT, REF, OOP
        static void PrintNumberFrom1ToN(in int n) 
        {
            //n = 5000;
            //keyword IN ở tham số biến tham số thành read-only
            //để đảm bảo code luôn xử lý đúng tham số đầu vào
            Console.WriteLine($"The list of numbers from 1 to {n}");
            int i = 0;
            do
            {
                i++;
                //Console.Write(i + " ");
                //Console.Write("{0} ", i);
                Console.Write($"{i}\t");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            } while (i < n);
            Console.WriteLine();
        }

        //static void PrintNumberFrom1ToN(int n)
        //{
        //    Console.WriteLine($"The list of numbers from 1 to {n}");
        //    int i = 0;
        //    do
        //    {
        //        i++;
        //        //Console.Write(i + " ");
        //        //Console.Write("{0} ", i);
        //        Console.Write($"{i}\t");
        //        if (i % 10 == 0)
        //        {
        //            Console.WriteLine();
        //        }
        //    } while (i < n);
        //    Console.WriteLine();
        //}

        //C4: VIẾT HÀM TÍNH TỔNG CỦA CÁC SỐ CHẴN TỪ 1 ĐẾN 10 (100)
        //2 4 6 8 10 => 30 Hàm viết thế nào không cần biết, chỉ cần biết rằng nó phải trả về hoặc in ra 30 - EXPECTED VALUE
        //CÒN THỰC TÉ LÚC CHẠY HÀM LÀ BAO NHIÊU, VÍ DỤ 30, 40, 60, CÓ KHI 30. ĐOÁN XEM, THÌ GIÁ TRỊ TRẢ VỀ CỦA HÀM ĐƯỢC GỌI LÀ ACTUAL VALUE
        //NẾU ACTUAL == EXPECTED => HÀM NGON CHO TÌNH HUỐNG NÀY
        //UNIT TEST TRONG MÔN SWT301
        static int SumEvens(int n)
        {
            //int s = 0;
            var s = 0; //java cũng có luôn
            //kỹ thuật ko chỉ rõ tường minh datatype của biến, mà datatype của biến sẽ đc suy luận từ giá trị gán vào, gán ngay lúc khai báo
            //type inferent: suy luận ngầm kiểu dât của biến
            //xài var bắt buộc phải gán giá trị khởi đầu
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    s += i;
                }
            }
            return s;
        }

        //C5: VIẾT HÀM TÍNH TỔNG TẤT CẢ CÁC SỐ LẺ TỪ 1 - 10
        //EXPECTED VALUE: 25
        //ACTUAL        : ??? CHỜ CHẠY APP
        static int SumOdds(int n)
        {
            var s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    s += i;
                }
            }
            return s;
        }


        //C6:
        //SQL:  SELECT SUM, COUNT, AVERAGE, ...
        //      FROM ...
        //      WHERE ...
        //      GROUP BY ...
        //      HAVING ...
        //LỠ 1 LẦN ĐI QUA TẬP DATA, TÍNH LUÔN NHIỀU GIÁ TRỊ
        //KẸT: HÀM TRONG JAVA, C, C# NÓI CHUNG CHỈ TRẢ VỀ 1 GIÁ TRỊ
        //CÓ CÁCH NÀO ĐỂ GIÚP HÀM TRẢ VỀ NHIỀU GIÁ TRỊ KHI CHỈ GỌI HÀM 1 LẦN, GIỐNG SELECT GỘP NHIỀU HÀM???
        //CÓ: OUT, VÀ REF




        
    }
}
