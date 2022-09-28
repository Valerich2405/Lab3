using System;

namespace Book
{
    class Book
    {
        public class Title
        {
            private string title;
            public Title(string _title)
            {
                this.title = _title;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Title: {title}");
            }
        }

        public class Author
        {
            private string author;
            public Author(string _author)
            {
                this.author = _author;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Author: {author}");
            }
        }

        public class Content
        {
            private string content;
            public Content(string _content)
            {
                this.content = _content;
            }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Content: {content}");
                Console.ResetColor();
            }
        }
    }
    class Program : Book
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book: ");

            Console.Write("Enter title: ");
            string t = Console.ReadLine();

            Console.Write("Enter author: ");
            string a = Console.ReadLine();

            Console.Write("Enter content: ");
            string c = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Your book: ");

            Book.Title title = new Book.Title(t);
            title.Show();

            Book.Author author = new Book.Author(a);
            author.Show();

            Book.Content content = new Book.Content(c);
            content.Show();
        }
    }
}
