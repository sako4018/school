using System;

namespace BankAccount
{
    public class BankAccount
    {
        public decimal Balance{get;private set;}
        public BankAccount()
        {
            Balance = 0m;
        }
        public BankAccount(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Negative balance. ");
            }
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            System.Console.WriteLine("First deposit: ");
            decimal first = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Second deposit: ");
            decimal second = decimal.Parse(Console.ReadLine());
            if (first > 0 && second > 0)
            {
                account.Deposit(first);
                account.Deposit(second);
                System.Console.WriteLine("Balance: {0:F2}", account.Balance);
            }
            else
            {
                System.Console.WriteLine("Amount must be positive. ");
            }
        }
    }
}
