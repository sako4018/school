using System;
using System.Collections.Generic;

namespace Task6_Frog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(',');
            List<int> stones = new List<int>();
            foreach (string part in parts)
            {
                stones.Add(int.Parse(part.Trim()));
            }

            Lake lake = new Lake(stones);

            string result = "";
            foreach (int stone in lake)
            {
                if (result != "")
                {
                    result += ", ";
                }
                result += stone;
            }
            Console.WriteLine(result);
        }
    }
}
