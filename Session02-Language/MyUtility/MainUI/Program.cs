using MainUI.Lyrics;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAge();
            //PrintLyricOrPoem();
            //UseVerbatim();
            LyricLibrary.PrintChungTaCuaTuongLai();

        }
        
        //verbatim string dùng để làm gì???
        //1 trong những cách dùng là dùng đễ gán đường dẫn tập tin trong Windows làm cho đường dẫn tự nhiên như lúc xài Windows
        //verbatim còn hay dùng trong chuỗi kết nối CSDL khi tên server có dấu // \\
        static void UseVerbatim()
        {
            //string filePath = "C:\\news";
            string filePath = @"C:\news"; //verbatim để dùng chuỗi nguyên bản tự nhiên như nó vẫn là 
                                        //\n là \n chứ k phải xuống hàng
                                        //kết hợp được với interpolation $
            Console.WriteLine(filePath);
            Console.WriteLine(@$"Your path: {filePath} \n \n");
        }


        //OOP: static chơi với static
        static void PrintLyricOrPoem()
        {
            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ");
            //Console.WriteLine("Mặt trời chân lý chói qua tim");
            //Console.WriteLine("Hồn tôi là một vườn hoa lá");
            //Console.WriteLine("Rất rộn hương và rộn tiếng chim");
            //Ctrl K C: comment, Ctrl K U: uncomment, mở gi chú của 1 đám lệnh
            //Java: Ctrl / 

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ\n" +
            //    "Mặt trời chân lý chói qua tim\n" +
            //    "Hồn tôi là một vườn hoa lá\n" +
            //    "Rất rộn hương và rộn tiếng chim");

            Console.WriteLine(@"
Từ ấy trong tôi bừng nắng hạ
Mặt trời chân lý chói qua tim
Hồn tôi là một vườn hoa lá
Rất rộn hương và rộn tiếng chim


<html>
    <body>
        <div>
        </div>
    </body>
</html>");
            //raw string: chuỗi nguyên bản, có gì in nấy
            //phế võ công tất cả các ký tự đặc biệt, trở lại thành ký tự bình thường, \n là \n chứ không phải xuống hàng - VERBATIM (Java có luôn)
            //DÙNG VERBATIM ĐỂ LÀM GÌ?
        }

        static void GetAge()
        {
            int yob = 2004; //biến khai báo trong hàm theo cú pháp con lạc đà - Camel Case Notation, ex: salary, radius, basicSalary
            int age = 2024 - yob;

            Console.WriteLine("Yob: " + yob + " | Age: " + age); //cw tab giống sout tab

            Console.WriteLine("Yob: {0} | Age: {1}", yob, age); //placeholder
            //                      thứ tự biến tính từ 0
            //                      danh sách biến sau dấu phẩy
            //                      %d, yob như bên C

            Console.WriteLine($"Yob: {yob} | Age: {age}"); //interpolation
            //tự suy luận đâu là biến để điền giá trị của biến vào chuỗi
        }
    }
}
