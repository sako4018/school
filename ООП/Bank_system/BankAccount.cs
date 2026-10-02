public class BankAccount
{
    private string _owner;
    private decimal _balance;

    public string Owner{get; private set;}
    public decimal Balance{get; private set;}

    public BankAccount(string owner, decimal initialBalance = 0)
    {
        Owner = owner;
        Balance = initialBalance;
    }
    public BankAccount() : this("Unknown", 0)
    {
        
    }
    public decimal Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater");
        }
        Balance += amount;
        return Balance;
    }
    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be greater");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }
        Balance -= amount;
        return Balance;
    }
    public decimal GetBalance()
    {
        return Balance;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Owner: {Owner}, Balance: {Balance}");
    }

}