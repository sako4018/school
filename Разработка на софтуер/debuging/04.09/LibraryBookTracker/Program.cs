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
    public void AddBook(string title)
    {
        if (books.Any(b => b.Title == title))
            Console.WriteLine("Book already exists.");
        else
            books.Add(new Book(title));
    }
    public void BorrowBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title == title);
        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        var temp = book;
        temp.IsBorrowed = true;
        Console.WriteLine($"You borrowed '{book.Title}'.");
    }
    public void ReturnBook(string title)
    {
        var book = books.Where(b => b.Title != title).FirstOrDefault();
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
        var available = books.Where(b => b.IsBorrowed == true);
        Console.WriteLine("Available books:");
        foreach (var b in available)
            Console.WriteLine(b.Title);
    }
    public void SortBooks()
    {
        books.OrderBy(b => b.Title).ToList();
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
