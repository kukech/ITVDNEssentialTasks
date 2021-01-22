using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Classes;

namespace Task3
{
    /*Создать класс Book. Создать классы  Title, Author и Content, каждый из которых должен содержать 
одно строковое поле и метод void Show().  
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
Выведите на экран разными цветами при помощи метода   Show()  название книги, имя автора и 
содержание.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input book title, author, content: ");
            string titleBook = Console.ReadLine(),
                   authorBook = Console.ReadLine(),
                   contentBook = Console.ReadLine();

            Book book = new Book(titleBook, authorBook, contentBook);
            book.Show();

            Console.ReadKey();
        }
    }
}
