using System;
using System.Diagnostics.Contracts;

namespace SharedBooks
{
    class Book
    {
        public string  Title { get;set; }
    }
    class Program
    {
        List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread[] threads = new Thread[]
            {
                new Thread(p.AddBookOnce){Name = "ProducerThread"},
                new Thread(p.RemoveBookOnce){Name = "ConsumerThread"},
                new Thread(p.PrintBookOnce){Name = "Printer Thread"}
            };

            foreach(var t in threads)
                t.Start();
            
            foreach(var t in threads)
                t.Join();
        }

        public void AddBookOnce()
        {
            System.Console.WriteLine($"[{Thread.CurrentThread.Name} Start...]");

            lock (books)
            {
                books.Add(new Book {Title = "Book A"});
                System.Console.WriteLine($"[{Thread.CurrentThread.Name}] Added one book.");
            }
            System.Console.WriteLine($"[{Thread.CurrentThread}] Ends");
        }

        public void RemoveBookOnce()
        {
            System.Console.WriteLine($"[{Thread.CurrentThread.Name}] Start...");

            lock (books)
            {
                if (books.Count > 0)
                {
                    books.RemoveAt(0);
                    System.Console.WriteLine($"[{Thread.CurrentThread.Name}] Removed one book.");
                }
                else
                {
                    System.Console.WriteLine($"[{Thread.CurrentThread.Name}] The list is empty.");
                }
            }
            System.Console.WriteLine($"[{Thread.CurrentThread.Name}] Ends");
        }

        public void PrintBookOnce()
        {
            System.Console.WriteLine($"[{Thread.CurrentThread.Name}] Start...");

            lock (books)
            {
                foreach (Book book in books)
                {
                    System.Console.WriteLine($"[{Thread.CurrentThread.Name}] {book.Title}");
                }
            }
            System.Console.WriteLine($"[{Thread.CurrentThread.Name}] Ends");
        }
    }
}
