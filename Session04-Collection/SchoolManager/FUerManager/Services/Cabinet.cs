using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Services
{
    public class Cabinet<T> //Data  type được đưa nào như là tham số - class chơi với nhiều loại data type khác nhau
    {
        //private T[] _arr;
        //private int _count = 0;

        private List<T> _arr = new List<T>();  //tự nở ra theo nhu cầu

        public void PrintItems()
        {
            //Kiểm tra nếu list không có giá trị
            if (_arr.Count == 0)
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            Console.WriteLine($"There is/are {_arr.Count} items in the cabinet!");

            foreach (T x in _arr)
            {
                Console.WriteLine(x); //gọi thầm tên em ToString
            }
        }

        public void AddAnItem(T x) => _arr.Add(x);
    }
}
