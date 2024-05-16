namespace Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegerList();
            PrintEvenList();
            PrintNumberFrom1ToN(100);
        }

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

        //C2: Viết hàm in ra các số chẵn từ 1 đến 100
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


        //C3: viết hàm in ra các số từ 1 đến N
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


    }
}
