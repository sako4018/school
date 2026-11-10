using System;
using System.Threading;

class BankAccount
{
    public int balance = 1000;

    private object locker = new object();

    public void Withdraw(int amount)
    {
        lock (locker)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Теглене: -{amount} лв. Нов баланс: {balance} лв.");
            }
            else
            {
                Console.WriteLine($"Недостатъчен баланс за теглене на {amount} лв. Текущ баланс: {balance} лв.");
            }
        }
    }

    public void Deposit(int amount)
    {
        lock (locker)
        {
            balance += amount;
            Console.WriteLine($"Депозит: +{amount} лв. Нов баланс: {balance} лв.");
        }
    }
}

class Program
{
    static BankAccount account = new BankAccount();

    static void Client()
    {
        for (int i = 0; i < 3; i++)
        {
            account.Withdraw(300);
            Thread.Sleep(100);
        }
    }

    static void Clerk()
    {
        for (int i = 0; i < 3; i++)
        {
            account.Deposit(200);
            Thread.Sleep(100);
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Thread clientThread = new Thread(Client);
        Thread clerkThread = new Thread(Clerk);

        clientThread.Start();
        clerkThread.Start();

        clientThread.Join();
        clerkThread.Join();

        Console.WriteLine($"Краен баланс: {account.balance} лв.");
    }
}
