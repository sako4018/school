using System;
using System.Collections;
using System.Collections.Generic;

namespace Task5_Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            T last = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return last;
        }

        // Обхожда от върха към дъното, без да премахва
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
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
