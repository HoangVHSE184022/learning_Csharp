using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;



namespace FUerManagerGeneric.Services
{
    public class Cabinet<T> //T: datatype
                            //hãy đưa kdl vào đi: Student, Lecturer, Tiger, Lion,....
                            //DATA TYPE DC XEM LÀ 1 THAM SỐ LUÔN
                            //CLASS LÀM VIỆC VỚI NHIỀU LOẠI DATA TYPE KHÁC NHAU -> GỌI LÀ GENERIC
                            //T: LÀ 1 BIẾN MÀ VALUE CỦA NÓ LÀ DATA TYPE THAY VÌ 5 10 15 20
    {
        private T[] _arr;
        private int _count = 0;

        

        public Cabinet(int size) 
        { 
            _arr = new T[size];
        }

        public void Add(T item) =>  _arr[_count++] = item;
        

        public void Print()
        {
            Console.WriteLine($"There is/are {_count} item(s) in Cabinet");
            for (int i = 0; i < _count; i++) 
                Console.WriteLine(_arr.ToString()); //gọi thầm tên em
            //ko thể gọi ShowProfile vì không viết class đưa vào có hay  không
            //gọi ToString để in info bên trong là chắc cú nhất
            
                
            
        }

        //CÁCH XÀI Cabinet<Student>
        //          Cabinet<Lecturer> //datatype đc đưa vào như tham số
        //                      data type là value
        //List<Student> bên java


    }
}
