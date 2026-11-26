using System;
using System.Collections;
using System.Collections.Generic;

namespace Task4_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = new List<T>(items);
            index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return index + 1 < items.Count;
        }

        public void Print()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(items[index]);
        }

        // Печата всички елементи на един ред. Курсорът (index) не се променя.
        public void PrintAll()
        {
            string line = "";
            foreach (T item in this)
            {
                if (line != "")
                {
                    line += " ";
                }
                line += item;
            }
            Console.WriteLine(line);
        }

        // Собствен итератор с yield return
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
