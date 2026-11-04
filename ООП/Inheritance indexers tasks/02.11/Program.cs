using System;

namespace Task_02_11
{
    class Book
    {
        public string Title {get; private set;}
        public string Genre {get; private set;}
        public int ID {get; private set;}
        
        static List<Book> AvailableBooks = new List<Book>();
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
        public string Author {get; private set;}
    }
    class CrimeBook : Book
    {
        public string Author {get; private set;}
    }
    class Book_Science : Book
    {
        public string Author {get; private set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
