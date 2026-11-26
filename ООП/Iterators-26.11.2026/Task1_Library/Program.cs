using System;

namespace Task1_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            // Проверка: колко книги има във всяка библиотека
            int countOne = 0;
            foreach (Book book in libraryOne)
            {
                countOne++;
            }
            Console.WriteLine("libraryOne: " + countOne + " книги");

            Console.WriteLine("libraryTwo:");
            foreach (Book book in libraryTwo)
            {
                Console.WriteLine(book.Title + " (" + book.Year + "), автори: " + book.Authors.Count);
            }
        }
    }
}
