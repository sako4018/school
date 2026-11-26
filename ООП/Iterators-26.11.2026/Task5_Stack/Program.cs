using System;

namespace Task5_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string line = Console.ReadLine();
            while (line != "END")
            {
                if (line.StartsWith("Push"))
                {
                    // "Push 1, 2, 3" -> махаме "Push" и разделяме по запетая
                    string numbers = line.Substring(4);
                    string[] parts = numbers.Split(',');
                    foreach (string part in parts)
                    {
                        stack.Push(int.Parse(part.Trim()));
                    }
                }
                else if (line == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                line = Console.ReadLine();
            }

            // Обхождаме стека два пъти
            for (int round = 0; round < 2; round++)
            {
                foreach (int number in stack)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
