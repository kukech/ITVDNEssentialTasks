using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Classes
{
    class Title
    {
        string titleBook;

        public string TitleBook
        {
            get
            {
                return titleBook;
            }
            set
            {
                titleBook = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(titleBook);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Author
    {
        string authorBook;

        public string AuthorBook
        {
            get
            {
                return authorBook;
            }
            set
            {
                authorBook = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(authorBook);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Content
    {
        string contentBook;
        public string ContentBook
        {
            get
            {
                return contentBook;
            }
            set
            {
                contentBook = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(contentBook);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public Book(string title, string author, string content)
            : this()
        {
            this.title.TitleBook = title;
            this.author.AuthorBook = author;
            this.content.ContentBook = content;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
