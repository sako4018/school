using System;
using System.Threading;
class Program
{
    static void RunRunner(object runnerId)
    {
        int id = (int)runnerId;

        for (int distance = 10; distance <= 100; distance = distance + 10)
        {
          
        }

    }
    static void Main()
    {
        Thread t1 = new Thread(RunRunner);
        Thread t2 = new Thread(RunRunner);
        Thread t3 = new Thread(RunRunner);

        

        Console.WriteLine("Всички състезатели приключиха!");
    }
}