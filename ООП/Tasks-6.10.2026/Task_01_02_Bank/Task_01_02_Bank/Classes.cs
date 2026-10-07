using System;
enum CurrencyType
{
    Lev,
    Euro,
    Dollar
}
class Customer
{
    public int CustomerId { get;  set; }
    public string Name { get;  set; }
    public decimal Address { get;  set; }
    public string PhoneNumber { get;  set; }
}
class Account
{
    public string AccountNumber { get;  set; }
    public int CustomerId { get;  set; }
    public decimal Balance { get;  set; }
    public CurrencyType Currency { get;  set; }
}
class Bank
{
    private List<Customer> customers = new List<Customer>();
    private List<Account> accounts = new List<Account>();

    public Customer FindCustomerById(int id)
    {
        foreach (Customer customer in customers)
        {
            if (customer.CustomerId == id)
            {
                return  customer;
            }
        }
        return null;
    }
    public Account FindAccountByNumber(string number)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == number)
            {
                return account;
            }
        }
        return null;
    }
    public bool RegisterCustomer(Customer customer)
    {
        if(customer.CustomerId <=0 || customer == null)
        {
            return false;
        }
        if (FindCustomerById(customer.CustomerId) != null)
        {
            return false;
        }
        customers.Add(customer);
        return true;
    }
    public bool CreateAccount(string number, int customerId, CurrencyType currency)
    {
        if(number == null || number == "")
        {
            return false; 
        }
        if(FindCustomerById(customerId) == null || FindAccountByNumber(number) != null)
        {
            return false;
        }
        Account account = new Account();
        account.AccountNumber = number; 
        account.CustomerId = customerId;
        account.Balance = 0;
        account.Currency = currency;
        accounts.Add(account);
        return true;
    }
    public bool Deposit(string number, decimal amount)
    {
        Account account = FindAccountByNumber(number);
        if(account == null || amount <= 0)
        {
            return false;
        }
        account.Balance += amount;
        return true;
    }
    public bool Withdraw(string number, decimal amount)
    {
        Account account = FindAccountByNumber(number);
        if(account == null || amount <= 0)
        {
            return false;
        }
        if(account.Balance < amount)
        {
            return false;
        }
        account.Balance -= amount;
        return true;
    }
}
