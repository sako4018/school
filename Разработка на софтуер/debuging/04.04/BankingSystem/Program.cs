using System;
class BankAccount
{
    public string Owner;
    public double Balance;
    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Deposited {amount} successfully!");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive!");
        }
    }
    public void Withdraw(double amount)
    {
        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount} successfully!");
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {Balance} lv.");
    }
}
class BankingSystem
{
    static void Main()
    {
        BankAccount account = new BankAccount("Ivan", 500);
        string command = "";
        Console.WriteLine("Welcome to the Banking System!");
        Console.WriteLine("Available commands: deposit, withdraw, balance, quit");
        while (command != "quit")
        {
            Console.Write("> ");
            command = Console.ReadLine();
            if (command == "deposit")
            {
                Console.Write("Enter amount: ");
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);
            }
            else if (command == "withdraw")
            {
                Console.Write("Enter amount: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
            else if (command == "balance")
            {
                account.ShowBalance();
            }
            else
            {
                Console.WriteLine("Unknown command!");
            }
        }
        Console.WriteLine("Thank you for using our bank!");
    }
}
