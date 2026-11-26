using System;
using System.Globalization; // 
class BankAccount
{
    public string Owner;
    public decimal Balance; // 
    public BankAccount(string owner, decimal balance) // 
    {
        Owner = owner;
        Balance = balance;
    }
    public void Deposit(decimal amount) // 
    {
        if (amount > 0)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Deposited {amount.ToString(CultureInfo.InvariantCulture)} successfully!"); //
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive!");
        }
    }
    public void Withdraw(decimal amount) // 
    {
        if (amount <= 0) //
        {
            Console.WriteLine("Withdraw amount must be positive!");
        }
        else if (amount > Balance) // 
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount.ToString(CultureInfo.InvariantCulture)} successfully!"); // 
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {Balance.ToString(CultureInfo.InvariantCulture)} lv."); // 
    }
}
class BankingSystem
{
    // 
    static bool ReadAmount(out decimal amount)
    {
        Console.Write("Enter amount (use a dot, e.g. 12.50): "); // 
        string input = Console.ReadLine();
        if (input == null) // 
        {
            amount = 0;
            return false;
        }
        if (!decimal.TryParse(input, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out amount)) //
        {
            Console.WriteLine("Invalid amount!");
            return false;
        }
        return true;
    }
    static void Main()
    {
        BankAccount account = new BankAccount("Ivan", 500m); // 
        string command = "";
        Console.WriteLine("Welcome to the Banking System!");
        Console.WriteLine("Available commands: deposit, withdraw, balance, quit");
        while (command != "quit")
        {
            Console.Write("> ");
            command = Console.ReadLine();
            if (command == null) // 
            {
                break;
            }
            if (command == "deposit")
            {
                decimal amount; // 
                if (ReadAmount(out amount)) 
                {
                    account.Deposit(amount);
                }
            }
            else if (command == "withdraw")
            {
                decimal amount; // 
                if (ReadAmount(out amount)) //
                {
                    account.Withdraw(amount);
                }
            }
            else if (command == "balance")
            {
                account.ShowBalance();
            }
            else if (command == "quit") // 
            {
            }
            else
            {
                Console.WriteLine("Unknown command!");
            }
        }
        Console.WriteLine("Thank you for using our bank!");
    }
}
