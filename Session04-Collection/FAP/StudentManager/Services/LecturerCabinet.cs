using StudentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arrLec;
        private int _count = 0;

        public int Count => _count;
        public LecturerCabinet()
        {
        }

        public LecturerCabinet(int size)
        {
            _arrLec = new Lecturer[size];
        }

        public void AddALecturer(Lecturer lecturer)
        {
            _arrLec[_count] = lecturer; 
            _count++;
        }

        public void PrintLecturerList()
        {
            Console.WriteLine($"There is/are {_count} Lecturer(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                _arrLec[i].ShowProfile();
            }
        }

        public void UpdateALecturer(string id)
        {
            int found = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_arrLec[i].Id == id)
                {
                    found = i;
                    break;
                }
            }

            if (found == 0)
            {
                Console.WriteLine("Cannot found Lecturer with Id " + id);
            }
            else
            {
                Console.WriteLine("Old Info:");
                _arrLec[found].ShowProfile();
                Console.Write("Enter new Id: "); _arrLec[found].Id = Console.ReadLine();
                Console.Write("Enter new Name: "); _arrLec[found].Name = Console.ReadLine();
                Console.Write("Enter new Yob: "); _arrLec[found].Yob = int.Parse(Console.ReadLine());
                Console.Write("Enter new Salary: "); _arrLec[found].Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Update Successfully!");
            }
        }

        public void DeleteALecturer(string id)
        {
            int found = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_arrLec[i].Id == id)
                {
                    found = i;
                    break;
                }
            }

            if (found == 0)
            {
                Console.WriteLine("Cannot found Lecturer with Id " + id);
            }
            else
            {
                _arrLec[found].Id = "";
                _arrLec[found].Name = "";
                _arrLec[found].Yob = 0;
                _arrLec[found].Salary = 0;

                Console.WriteLine("Delete Successfully!");
            }
        }
    }
}
