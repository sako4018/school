using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Book
{
    private string _title;
    private string _author;
    private int _pages;
    private int _year;

    public string Title{get; private set;}
    public string Author{get; private set;}
    public int Pages{get; private set;}
    public int Year{get; private set;}

    
    public Book(string title, string author, int pages, int year)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Year = year;
    }
}

class Library
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book b)
    {
        if(b != null)
        books.Add(b);
    }

    public Book FindBook(string title)
    {
        foreach (var b in books)
        {
            if(b.Title == title)
            {
                return b;
            }
        }
        return null;
    }

    public int GetTotalPages()
    {
        int totalCount = 0;
        foreach (var b in books)
        {
            totalCount = b.Pages + totalCount;
        }
        return totalCount;
    }

    public Book GetOldestBook()
    {
        if(books.Count == 0)
        {
            
        }
        Book oldest = books[0];
        foreach(Book book in books)
        {
            if(book.Year < oldest.Year)
            {
                oldest = book;
            }       
        }
        return oldest;
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();
        lib.AddBook(new Book("Под игото", "Иван Вазов", 500, 1894));
        lib.AddBook(new Book("Бай Ганьо", "Алеко", 300, 1895));

        Book found = lib.FindBook("Под игото");
        Console.WriteLine("Намерена книга: " + (found != null ? found.Title : "няма"));

        Console.WriteLine("Общ брой страници: " + lib.GetTotalPages());

        Book oldest = lib.GetOldestBook();
        Console.WriteLine("Най-стара книга: " + (oldest != null ? oldest.Title : "няма"));
    }
}
