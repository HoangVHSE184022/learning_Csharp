using FUerManagerGeneric.Entities;
using FUerManagerGeneric.Services;

namespace FUerManagerGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MUA TỦ ĐỰNG HỒ SƠ SV

            //MUA 1 TỦ ĐỰNG HỒ SƠ GV

            //MUA THÊM 1 TỦ QUẢN LÝ INFO CÁC BÉ CƯNG - PET

            Cabinet<Student> tuSEStudent = new Cabinet<Student>(10);
            //List<Student>              = new ArrayList<Student>();

            tuSEStudent.Add(new Student() { Id = "SE1", Name = "An" });
            tuSEStudent.Add(new Student() { Id = "SE2", Name = "Bình" });

            Cabinet<Lecturer> tuSELecturer = new Cabinet<Lecturer>(10);

            tuSELecturer.Add(new Lecturer() { Id = "000012345", Name = "An", Salary = 20_000_000 });
            tuSELecturer.Add(new Lecturer() { Id = "000012346", Name = "Bình", Salary = 25_000_000 });

            tuSEStudent.Print();
            tuSELecturer.Print();

        }
    }
}
