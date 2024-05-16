using BmiV2;

namespace LibraryUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine($"BMI: {bmi}");
        }
    }
}
