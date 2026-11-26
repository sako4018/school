using System;
using System.Globalization; // FIX: needed for CultureInfo (decimal separator is always a dot)
class BankAccount
{
    public string Owner;
    public decimal Balance; // FIX: decimal instead of double for money
    public BankAccount(string owner, decimal balance) // FIX: decimal instead of double
    {
        Owner = owner;
        Balance = balance;
    }
    public void Deposit(decimal amount) // FIX: decimal instead of double
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
    public void Withdraw(decimal amount) // FIX: decimal instead of double
    {
        if (amount <= 0) // FIX: withdraw amount must be positive
        {
            Console.WriteLine("Withdraw amount must be positive!");
        }
        else if (amount > Balance) // FIX: cannot withdraw more than the balance (equal is allowed)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount} successfully!");
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {Balance} lv.");
    }
}
class BankingSystem
{
    // FIX: reads an amount safely; returns false if the input is missing or not a number (no exception)
    static bool ReadAmount(out decimal amount)
    {
        Console.Write("Enter amount (use a dot, e.g. 12.50): "); // FIX: tell the user which decimal separator to use
        string input = Console.ReadLine();
        if (input == null) // FIX: end of input
        {
            amount = 0;
            return false;
        }
        if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out amount)) // FIX: TryParse with a fixed culture instead of Parse
        {
            Console.WriteLine("Invalid amount!");
            return false;
        }
        return true;
    }
    static void Main()
    {
        BankAccount account = new BankAccount("Ivan", 500m); // FIX: 500m is a decimal
        string command = "";
        Console.WriteLine("Welcome to the Banking System!");
        Console.WriteLine("Available commands: deposit, withdraw, balance, quit");
        while (command != "quit")
        {
            Console.Write("> ");
            command = Console.ReadLine();
            if (command == null) // FIX: end of input ends the loop
            {
                break;
            }
            if (command == "deposit")
            {
                decimal amount; // FIX: decimal instead of double
                if (ReadAmount(out amount)) // FIX: no crash on invalid input
                {
                    account.Deposit(amount);
                }
            }
            else if (command == "withdraw")
            {
                decimal amount; // FIX: decimal instead of double
                if (ReadAmount(out amount)) // FIX: no crash on invalid input
                {
                    account.Withdraw(amount);
                }
            }
            else if (command == "balance")
            {
                account.ShowBalance();
            }
            else if (command == "quit") // FIX: quit must not print "Unknown command!"
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
