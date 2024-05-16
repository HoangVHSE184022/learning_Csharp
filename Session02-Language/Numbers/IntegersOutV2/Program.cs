namespace IntegersOutV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hàm trả về 6 món
            int sumA = ComputeNumbers(out int sumO, out int countO, out int sumE, out int countE, out int countP);
            Console.WriteLine("Sum all: " + sumA);
            Console.WriteLine("Sum Odds: " + sumO);
            Console.WriteLine("Count Odds: " + countO);
            Console.WriteLine("Sum Evens: " + sumE);
            Console.WriteLine("Count Evens: " + countE);
            Console.WriteLine("Count Primes: " + countP);
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
        static int ComputeNumbers(out int sumOdds, out int countOdds, out int sumEvens, out int countEvens, out int countPrimes)
        {
            sumOdds = 0;
            countOdds = 0;
            sumEvens = 0;
            countEvens = 0;
            countPrimes = 0;
            int sumAll = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;
                if (i % 2 == 1)
                {
                    sumOdds += i;
                    countOdds += 1;
                }
                else
                {
                    sumEvens += i;
                    countEvens += 1;
                }
                if (IsPrime(i)) countPrimes++;
            }
            
            return sumAll;
        }

        static bool IsPrime(int n)
        {
            //viết code for đến căn bậc 2 tìm ước số
            //nếu lỡ chia hết, false liền
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
