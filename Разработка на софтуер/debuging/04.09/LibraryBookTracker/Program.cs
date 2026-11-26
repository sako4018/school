using System;
using System.Collections.Generic;
using System.Linq;
class Book
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public Book(string title)
    {
        Title = title;
        IsBorrowed = false;
    }
}
class Library
{
    private List<Book> books = new List<Book>();
    //
    private Book FindBook(string title) //
    {
        return books.FirstOrDefault(b => string.Equals(b.Title, title, StringComparison.OrdinalIgnoreCase));
    }
    public void AddBook(string title)
    {
        if (FindBook(title) != null) //
            Console.WriteLine("Book already exists.");
        else
            books.Add(new Book(title));
    }
    public void BorrowBook(string title)
    {
        var book = FindBook(title); //
        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (book.IsBorrowed) //
        {
            Console.WriteLine("This book is already borrowed.");
            return;
        }
        book.IsBorrowed = true; //
        Console.WriteLine($"You borrowed '{book.Title}'.");
    }
    public void ReturnBook(string title)
    {
        var book = FindBook(title); //
        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (!book.IsBorrowed)
        {
            Console.WriteLine("This book was not borrowed.");
            return;
        }
        book.IsBorrowed = false;
        Console.WriteLine($"Returned '{book.Title}'.");
    }
    public void ShowAvailable()
    {
        var available = books.Where(b => b.IsBorrowed == false); //
        Console.WriteLine("Available books:");
        foreach (var b in available)
            Console.WriteLine(b.Title);
    }
    public void SortBooks()
    {
        books = books.OrderBy(b => b.Title, StringComparer.OrdinalIgnoreCase).ToList(); //
    }
}
class Program
{
    static void Main()
    {
        Library lib = new Library();
        lib.AddBook("1984");
        lib.AddBook("The Hobbit");
        lib.AddBook("Dune");
        lib.BorrowBook("dune");
        lib.ReturnBook("1984");
        lib.ShowAvailable();
        lib.SortBooks();
        lib.ShowAvailable();
    }
}
