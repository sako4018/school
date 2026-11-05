public class BankAccount
{
    public decimal Balance{ get; private set; }

    public bool IsEmpty
    {
        get { return Balance == 0; }
    }
    public BankAccount()
    {
        Balance = 0;
    }
    public BankAccount(decimal balance)
    {
        if (balance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be negative");
        }
        Balance = balance;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("amount", "Deposit amount must be positive");
        }
        Balance += amount;
    }
    public void WithDraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException("amount", "Withdraw amount must be positive");
        }
        if(amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds for this withdrawal");
        }
        Balance -= amount;
    }

}