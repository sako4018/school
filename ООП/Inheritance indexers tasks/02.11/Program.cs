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
            if (AvailableBooks.Contains(this))
            {
                return false;
            }
            else
            {
                AvailableBooks.Add(this);
                return true;
            }
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
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
