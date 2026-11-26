using System;
using System.Collections.Generic;

namespace Task3_ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първият ред е винаги Create {елементи}
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> elements = new List<string>();
            for (int i = 1; i < parts.Length; i++)
            {
                elements.Add(parts[i]);
            }
            ListyIterator<string> iterator = new ListyIterator<string>(elements);

            string command = Console.ReadLine();
            while (command != "END")
            {
                try
                {
                    if (command == "Move")
                    {
                        Console.WriteLine(iterator.Move());
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(iterator.HasNext());
                    }
                    else if (command == "Print")
                    {
                        iterator.Print();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
