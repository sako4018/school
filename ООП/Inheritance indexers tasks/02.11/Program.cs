using System;
using System.Collections.Generic;

namespace Task_02_11
{
    class Book
    {
        static int nextID = 1;
        public string Title { get; }
        public string Genre { get; }
        public int ID { get; }

        public static List<Book> AvailableBooks = new List<Book>();

        public Book(string title, string genre)
        {
            Title = title;
            Genre = genre;
            ID = nextID++;
        }

        public virtual bool AddToCollection()
        {
            if (AvailableBooks.Contains(this))
            {
                return false;
            }
            AvailableBooks.Add(this);
            return true;
        }

        public static void PrintAvailableBooks()
        {
            Console.WriteLine("Налични книги:");
            foreach (Book book in AvailableBooks)
            {
                Console.WriteLine($"  {book.ID}, {book.Title}, {book.Genre}");
            }
            if (AvailableBooks.Count == 0)
            {
                Console.WriteLine("  Няма книги");
            }
        }

        public static Book FindAvailable(int id)
        {
            foreach (Book book in AvailableBooks)
            {
                if (book.ID == id)
                {
                    return book;
                }
            }
            return null;
        }
    }

    class Book_Romance : Book
    {
        public Book_Romance(string title) : base(title, "romance")
        {
        }

        public override bool AddToCollection()
        {
            bool success = base.AddToCollection();
            if (success)
            {
                Console.WriteLine($"Добавена романтична книга: {Title}");
            }
            return success;
        }
    }

    class Book_Crime : Book
    {
        public Book_Crime(string title) : base(title, "crime")
        {
        }

        public override bool AddToCollection()
        {
            bool success = base.AddToCollection();
            if (success)
            {
                Console.WriteLine($"Добавена криминална книга: {Title}");
            }
            return success;
        }
    }

    class Book_Science : Book
    {
        public Book_Science(string title) : base(title, "science")
        {
        }

        public override bool AddToCollection()
        {
            bool success = base.AddToCollection();
            if (success)
            {
                Console.WriteLine($"Добавена научна книга: {Title}");
            }
            return success;
        }
    }

    class Reader
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Book> Books { get; } = new List<Book>();

        public Reader(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public virtual bool TakeBook(Book book)
        {
            if (!Book.AvailableBooks.Contains(book))
            {
                Console.WriteLine("Книгата не е налична");
                return false;
            }
            Book.AvailableBooks.Remove(book);
            Books.Add(book);
            Console.WriteLine($"{Name} взе {book.Title}");
            return true;
        }
    }

    class StudentReader : Reader
    {
        public StudentReader(string name, string phone) : base(name, phone)
        {
        }

        public override bool TakeBook(Book book)
        {
            bool success = base.TakeBook(book);
            if (success)
            {
                Console.WriteLine($"{Name} is studying hard!");
                if (book.Genre == "science")
                {
                    Console.WriteLine($"{Name} се интересува от наука");
                }
            }
            return success;
        }
    }

    class RegularReader : Reader
    {
        public RegularReader(string name, string phone) : base(name, phone)
        {
        }

        public override bool TakeBook(Book book)
        {
            bool success = base.TakeBook(book);
            if (success)
            {
                Console.WriteLine($"{Name} is reading for fun!");
                if (book.Genre == "crime")
                {
                    Console.WriteLine($"{Name} се интересува от криминални книги");
                }
            }
            return success;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book romance = new Book_Romance("Pride and Prejudice");
            Book science = new Book_Science("A Brief History of Time");
            Book crime = new Book_Crime("Murder on the Orient Express");

            romance.AddToCollection();
            science.AddToCollection();
            crime.AddToCollection();
            Book.PrintAvailableBooks();
            Console.WriteLine();

            StudentReader student = new StudentReader("Ivan", "0888111222");
            RegularReader regular = new RegularReader("Maria", "0888333444");

            student.TakeBook(science);
            Book.PrintAvailableBooks();
            Console.WriteLine($"Книги на {student.Name}: {student.Books.Count}, Id {student.Books[0].ID}");
            Console.WriteLine();

            regular.TakeBook(crime);
            Book.PrintAvailableBooks();
            Console.WriteLine();

            Console.WriteLine("Повторен опит за книга 2:");
            bool again = regular.TakeBook(science);
            Console.WriteLine($"Резултат: {again}");
            Console.WriteLine();

            Console.WriteLine("Втори екземпляр със същото заглавие:");
            Book secondCopy = new Book_Science("A Brief History of Time");
            secondCopy.AddToCollection();
            Console.WriteLine($"Повторно добавяне на същия екземпляр: {secondCopy.AddToCollection()}");
            Book.PrintAvailableBooks();
        }
    }
}
