using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2_LibraryIterator
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Вложен клас - ръчен итератор
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.books = new List<Book>(books);
                currentIndex = -1;
            }

            public Book Current
            {
                get
                {
                    if (currentIndex < 0 || currentIndex >= books.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return books[currentIndex];
                }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public void Dispose()
            {
                // Няма какво да се освобождава
            }
        }
    }
}
