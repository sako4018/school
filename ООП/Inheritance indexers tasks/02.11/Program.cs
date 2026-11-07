using System;

namespace Task_02_11
{
    class Book
    {
        static int nextID = 1;
        public string Title {get;}
        public string Genre {get;}
        public int ID {get;}
        
        static List<Book> AvailableBooks = new List<Book>();

        public Book(string title, string genre)
        {
            Title = title;
            Genre = genre;
            ID = nextID ++;
        }
       
        public virtual bool AddToCollection()
        {
            if(AvailableBooks.Count < 100)
            {
                AvailableBooks.Add(this);
                return true;
            }
            else
            {
                return false;
            }

        }
        public void PrintAvailableBooks()
        {
            System.Console.WriteLine("AvailableBooks: ");
            foreach(Book book in AvailableBooks)
            {
                System.Console.WriteLine($"{book.ID}, {book.Title}, {book.Genre}");
            }
            if(AvailableBooks.Count == 0)
            {
                System.Console.WriteLine("No book");
            }
        }
        public static Book FindAvailable(int id)
        {
            foreach(Book book in AvailableBooks)
            {
                if(book.ID == id)
                {
                    return book;
                }
            }
        }
    }
    class Book_Romance : Book
    {
        public Book_Romance(string title): base(title, "romance")
        {

        }
        public override bool AddToCollection()
        {
            bool success = base.AddToCollection();
            if (success)
            {
                System.Console.WriteLine($"Added romantic: {Title}");
            }
            return success;
        }
        public string Author {get; private set;}
    }
    class CrimeBook : Book
    {
        public CrimeBook(string title): base(title, "crime")
        {
            
        }
         public override bool AddToCollection()
        {
            bool success = base.AddToCollection();
            if (success)
            {
                System.Console.WriteLine($"Added crime: {Title}");
            }
            return success;
        }
        public string Author {get; private set;}
    }
    class Book_Science : Book
    {
        public Book_Science(string title): base(title, "science")
        {
            
        }
         public override bool AddToCollection()
        {
            bool success = base.AddToCollection();
            if (success)
            {
                System.Console.WriteLine($"Added science: {Title}");
            }
            return success;
        }
        public string Author {get; private set;}
    }
    class Reader
    {
        public string Name{get;set;}
        public string Phone{get;set;}
        public List<Book> Books {get;} = new List<Book>();
        public Reader(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public virtual bool TakeBook(Book book)
        {
            if ()
            {
                Book.AvailableBooks.Remove(book);
                Books.Add(book);
                System.Console.WriteLine($"{Name} takes {book.Title}");
                return true;
            }
        }
    }
    class StudentReader : Reader
    {
        public StudentReader(string name, string phone): base(name, phone)
        {
            
        }
        public override bool TakeBook(Book book)
        {
            bool success = base.TakeBook(book);
            if (success)
            {
                Console.WriteLine($"{Name} is studying hard");
            }
            if(book.Genre == "Science")
            {
                System.Console.WriteLine("Science interest");
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
                Console.WriteLine($"{Name} is studying hard");
            }
            if(book.Genre == "Science")
            {
                System.Console.WriteLine("Science interest");
            }
            return success;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book romance = new Book_Romance(title, );
        }
    }
}
