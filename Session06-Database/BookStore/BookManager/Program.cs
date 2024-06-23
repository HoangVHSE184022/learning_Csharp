using Repositories;
using Repositories.Entities;

namespace BookManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // THÊM CUỐN SÁCH XEM SSAO, GỌI CABINET DBCONTEXT

            //BookManagementDbContext context = new();
            //context.Books.Add(new Book() { BookId = 999, BookName = "Conan", Author = "Japan", Description = "...", Price = 200, Quantity = 100, BookCategoryId = 1, PublicationDate = DateTime.Now});

            //context.SaveChanges(); //chạy lần 2 lỗi

            List<Book> arr = new BookManagementDbContext().Books.ToList();
            //đã select * from rồi
            //in 17 cuốn sách, loop

            Console.WriteLine("The list of books in table");
            foreach (Book x in arr)
                Console.WriteLine($"{x.BookId} | {x.BookName} | {x.Author} | {x.BookCategoryId}");
        }
    }
}
