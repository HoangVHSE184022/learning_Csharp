namespace ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntegerListV4();
        }

        //CHALLENGE 1: HÃY LƯU TRỮ DÃU SỐ 5 10 15 20 25 30 35 40 45 50 ... VÀ IN RA MÀN HÌNH

        static void PlayWithIntegerListV4()
        {
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //in mảng
            Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");

            //vì các biến lẻ trong mảng dùng chỉ số từ 0 để phân biệt: 0, 1, 2, 3, 4,... tăng đần => vòng lặp xuất hiện
            //=> MẢNG CHƠI VỚI LẶP
            Console.WriteLine("The list of 5 10 15 ... printed by using for i");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("The list of 5 10 15 ... printed by using foreach");
            foreach (int x in arr)
            { //toán tử với mọi x thuộc tập số N arr
              //x là 1 con số nguyên có quyền mang giá trị 
              //là x = arr[0], x = arr[1], x = arr[2]
                Console.Write(x + " ");

            }
            Console.WriteLine();

            foreach (var x in arr)
            { //x chính là 1 con int do nó ứng với arr[i], mảng số nguyên
                Console.Write($"{x} ");

            }
            Console.WriteLine();
        }

        static void PlayWithIntegerListV3()
        {
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //[] nhiều biến int
            //            [0] [1] [2]
            //            các biến int như bth kèm theo value
            //            int x = 5, x được gọi tên mới là arr[0]
            //            tên biến lẻ nay hơi dài về tên thêm 1 chút
            //arr LÀ BIẾN MÁ MÌ QUẢN LÍ DƯỚI TAY, DƯỚI TRƯỚNG 10 EM BIẾN INT LẺ [0] [1] [2]
            //ARR LÀ BIẾN CON TRỎ TRỎ VÙNG NEW BỰ CHỨA 10 BIẾN INT
            //vậy arr có quyền chấm để đi vào vùng NEW
            //ARR LÀ BIẾN OBJECT, VÌ TRỎ VÙNG NEW BỰ PHỨC TẠP
            //                    VÌ VÙNG NEW BỰ CÓ 10 BIẾN INT
            //MẢNG LÀ BIẾN THAM CHIẾU LUÔN

        }

        static void PlayWithIntegerListV2()
        {
            //CÁCH HIỆN ĐẠI, HIỆU QUẢ - KHAI BÁO SỈ
            //CÁCH VIẾT, CÚ PHÁP SẼ KHÓ HƠN
            int a = 5, b = 10, c = 15, d = 20;
            int[] arr1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //NEW NGẦM, arr1 = new int[10];
            int[] arr2 = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];
            //NEW NGẦM LUÔN
            int[] arr3 = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr4 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr5 = new int[10];
            //có 10 biến int riêng lẻ nhưng được khai báo nhanh bằng 1 câu lệnh
            //10 biến int này là arr5[0], arr5[2], ...
            arr5[0] = 5;
            arr5[1] = 10;
            arr5[2] = 15;
            arr5[3] = 20;
            arr5[4] = 25;
            arr5[5] = 30;
            arr5[6] = 35;
            arr5[7] = 40;
            arr5[8] = 45;
            arr5[9] = 50;

            //KHAI BÁO MẢNG
            //MẢNG CHỈ LÀ KỸ THUẬT KHAI BÁO NHIỀU BIẾN (khai báo sỉ)
            //CÙNG 1 LÚC, CÙNG 1 KIỂU DL, CÙNG 1 TÊN Ở SÁT NHAU TRONG RAM

            //KHAI BÁO MẢNG LÀ KHAI BÁO NHIỀU BIẾN ĐỂ CHỨA NHIỀU GIÁ TRỊ TRONG RAM\
            //KHAI BÁO 1 CÁCH HIỆU QUẢ, NHANH GỌN

            //DO MẢNG LÀ ĐẠI DIỆN CHO NHIỀU BIẾN TRÙNG TÊN TRÙNG KIỂU, DO ĐÓ ĐỂ PHÂN BIỆT TỪNG BIẾN LẺ, TA DÙNG [INDEX] ĐẾM TỪ 0

            //BIẾN THỨ [0], BIẾN THỨ [1], BIẾN THỨ [2]

            //CÓ 3 THỨ CẦN LƯU Ý KHI CHƠI MẢNG
            //TÊN MẢNG
            //NEW [] NEW NGOẶC VUÔNG

        }

        static void PlayWithIntegerListV1()
        {
            //CÁCH TRUYỀN THỐNG KIỂU TRÂU BÒ - KHAI BÁO LẺ, BIẾN LẺ, BIẾN RỜI RẠC, TỪNG BIẾN 1
            //biến: tên gọi cho value nào đó
            //int a, b, c, d, e, f, g, h, i, j;
            //a = 5;
            //b = 10;
            //c = 15;
            //d = 20;
            //e = 25;
            //f = 30;
            //g = 35;
            //h = 40;
            //i = 45;
            //j = 50;

            int a = 5, b = 10, c = 15, d = 20, e = 25, f = 30, g = 35, h = 40, i = 45, j = 50;

            //in ra màn hình
            Console.WriteLine("The list of 5, 10, 15, ...");
            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i}, {j}");
        }
    }
}
