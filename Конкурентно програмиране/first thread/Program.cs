namespace _1_зад;
class Program
{
    public static void DoTask1()
    {
        Console.WriteLine("Do this: Task1!");
        Thread.Sleep(1000);
    }
    public static void DoTask2()
    {
        System.Console.WriteLine("Do this: Task2!");
    }
    static void Main(string[] args)
    {
        Thread Pesho = new Thread(DoTask1);
        Thread Gosho = new Thread(DoTask2);
        Pesho.Start();
        Gosho.Start();
    }
}
