using System;

namespace Task8_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int number = int.Parse(parts[1]);

                if (parts[0] == "Add")
                {
                    list.Add(number);
                }
                else if (parts[0] == "Remove")
                {
                    list.Remove(number);
                }
            }

            Console.WriteLine(list.Count);

            string line = "";
            foreach (int item in list)
            {
                if (line != "")
                {
                    line += " ";
                }
                line += item;
            }
            Console.WriteLine(line);
        }
    }
}
