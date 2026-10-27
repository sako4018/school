using System;
using System.Threading;

namespace ArrayAndThreads
{
    class Program
    {
        static int[] numbers = { 4, 7, 2, 9, 6 };

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            threads[0] = new Thread(PrintNumbers);
            threads[1] = new Thread(PrintNumbers);
            threads[2] = new Thread(FindEvenNumbers);
            threads[3] = new Thread(FindEvenNumbers);
            threads[4] = new Thread(SumEvenNumbers);

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
        }

        static void PrintNumbers()
        {
            string result = "All numbers: ";
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i] + " ";
            }
            Console.WriteLine(result);
        }

        static void FindEvenNumbers()
        {
            string result = "Even numbers: ";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result = result + numbers[i] + " ";
                }
            }
            Console.WriteLine(result);
        }

        static void SumEvenNumbers()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }
            Console.WriteLine($"Sum of even numbers: {sum}");
        }
    }
}
