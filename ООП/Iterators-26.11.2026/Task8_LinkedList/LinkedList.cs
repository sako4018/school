using System;
using System.Collections;
using System.Collections.Generic;

namespace Task8_LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        // Добавя в края
        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        // Премахва първото съвпадение. Връща true само ако е премахнат елемент.
        public bool Remove(T item)
        {
            Node<T> previous = null;
            Node<T> current = head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    if (previous == null)
                    {
                        // Махаме първия възел
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    if (current == tail)
                    {
                        // Махаме последния възел
                        tail = previous;
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
