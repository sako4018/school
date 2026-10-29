using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4,5,6,8};
            Calculate(array);

        }

        static int Calculate(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += sum;
            }

            return sum;
        }
    }
}
