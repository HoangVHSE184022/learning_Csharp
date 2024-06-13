using FUerManager.Entities;
using FUerManager.Services;

namespace FUerManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentCabinet();
        }

        //Design pattern GoF - 23 patterns
        //Solid (Dependency injection)

        static void PlayWithStudentCabinet()
        {
            Cabinet<Student> tuSE = new Cabinet<Student>();
            tuSE.AddAnItem(new Student() { Id = "SE1"});
            tuSE.AddAnItem(new Student() { Id = "SE2", Name = "Bình" });

            tuSE.PrintItems(); //DELEGATE
        }

            static void PlayWithIntegerCabinet()
        {
            Cabinet<int> loto = new Cabinet<int>();
            loto.AddAnItem(5);
            loto.AddAnItem(10);
            loto.AddAnItem(15);
            loto.AddAnItem(20); //type-safe: không add lộn xộn

            loto.PrintItems();
        }
    }
}
