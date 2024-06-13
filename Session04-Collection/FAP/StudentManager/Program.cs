using StudentManager.Services;
using StudentManager.Entities;

namespace StudentManager
{
    internal class Program
    {
        static StudentCabinet tuSE = new StudentCabinet();
        static LecturerCabinet tuLec = new LecturerCabinet();

        static void Main(string[] args)
        {

            //đi mua cái tủ đựng hồ sơ
            //Cabinet tuSE = new Cabinet();   //Có sẵn ngăn 30 tủ đựng hồ sơ
            //Đang empty _count = 0
            StudentCabinet tuBiz = new StudentCabinet();  //có thêm 30 ngăn khác, empty = 0
            //2 vùng new riêng biệt, 2 tủ riêng biệt

            tuSE.AddAStudent(new Student() { Id = "SE1", Name = "An" });
            tuSE.AddAStudent(new Student() { Id = "SE2", Name = "Bình" });
            tuSE.AddAStudent(new Student() { Id = "SE3", Name = "Cường" });
            tuSE.AddAStudent(new Student() { Id = "SE4", Name = "Dũng" });

            tuBiz.AddAStudent(new Student() { Id = "Biz1", Name = "Dũng" });

            //in tủ
            tuSE.PrintStudentList();
            tuBiz.PrintStudentList();
            Console.WriteLine("\n");

            string choice = "";
            bool check = false;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                    MENU                   |");
            Console.WriteLine("| 1 - Student Management                    |");
            Console.WriteLine("| 2 - Lecturer Management                   |");
            Console.WriteLine("| 3 - Quit                                  |");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter a choice (1..2): ");
            choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    StudentManagement();
                    break;
                case "2":
                    LecturerManagement();
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice!!!");
                    return;
            }
        }

        static void StudentManagement()
        {

            string choice = "";
            bool check = false;
            string id = "", name = "";
            int yob = 0;
            double gpa = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("|             STUDENT MANAGEMENT            |");
                Console.WriteLine("| 1 - Add a new Student                     |");
                Console.WriteLine("| 2 - Print out Student list                |");
                Console.WriteLine("| 3 - Update a Student's Information        |");
                Console.WriteLine("| 4 - Delete a Student by Id                |");
                Console.WriteLine("| 5 - Quit                                  |");
                Console.WriteLine("---------------------------------------------");

                Console.Write("Enter a choice (1..2): ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("> Please enter these fields <");
                        Console.Write("Id: "); id = Console.ReadLine();
                        Console.Write("Name: "); name = Console.ReadLine();
                        Console.Write("Yob: "); yob = int.Parse(Console.ReadLine());
                        Console.Write("Gpa: "); gpa = double.Parse(Console.ReadLine());
                        Student student = new Student(id, name, yob, gpa);

                        tuSE.AddAStudent(student);

                        Console.WriteLine("Added!");

                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();

                        break;
                    case "2":
                        tuSE.PrintStudentList();
                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Enter Student Id to Update: "); id = Console.ReadLine();
                        tuSE.UpdateAStudent(id);
                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Enter Student Id to Delete: "); id = Console.ReadLine();
                        tuSE.DeleteAStudent(id);
                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!!!");
                        return;

                }
                check = choice.Equals("1") ? true : false;
            } while (check);

        }

        static void LecturerManagement()
        {

            string choice = "";
            bool check = false;
            string id = "", name = "";
            int yob = 0;
            double salary = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("|             LECTURER MANAGEMENT           |");
                Console.WriteLine("| 1 - Add a new Lecturer                    |");
                Console.WriteLine("| 2 - Print out Lecturer list               |");
                Console.WriteLine("| 3 - Update a Lecturer's Information       |");
                Console.WriteLine("| 4 - Delete a Lecturer by Id               |");
                Console.WriteLine("| 5 - Quit                                  |");
                Console.WriteLine("---------------------------------------------");

                Console.Write("Enter a choice (1..2): ");
                choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("> Please enter these fields <");
                        Console.Write("Id: "); id = Console.ReadLine();
                        Console.Write("Name: "); name = Console.ReadLine();
                        Console.Write("Yob: "); yob = int.Parse(Console.ReadLine());
                        Console.Write("Salary: "); salary = double.Parse(Console.ReadLine());
                        Lecturer lecturer = new Lecturer(id, name, yob, salary);

                        tuLec.AddALecturer(lecturer);

                        Console.WriteLine("Added!");

                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();

                        break;
                    case "2":
                        tuLec.PrintLecturerList();
                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Enter Lecturer Id to Update: "); id = Console.ReadLine();
                        tuLec.UpdateALecturer(id);
                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Enter Lecturer Id to Delete: "); id = Console.ReadLine();
                        tuLec.DeleteALecturer(id);
                        Console.Write("Continue? (1: YES | 0: NO): "); choice = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!!!");
                        return;

                }
                check = choice.Equals("1") ? true : false;
            } while (check);

        }
    }
}

//BTVN - ASS2 LMS 
//DEADLINE: 10/6 TRƯỚC 15H00

//Viêt thêm bên Main cái menu in ra 
//1. Thêm mới: nhập từ bàn phím, nhớ convert từ chữ sang số kiểu Integer.parseInt()
//2. In
//3. Xóa sửa gì đó (ko bắt buộc)

//viết thêm cái tủ đựng hồ sơ giảng viên (id, name, yob, salary) - class giảng viên - class tủ đựng gv
