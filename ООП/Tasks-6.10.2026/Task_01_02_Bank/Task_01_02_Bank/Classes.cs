using System;
enum CurrencyType
{
    Lev,
    Euro,
    Dollar
}
class Customer
{
    public int CustomerId { get; private set; }
    public string Name { get; private set; }
    public decimal Address { get; private set; }
    public string PhoneNumber { get; private set; }
}
class Account
{
    public string AccountNumber { get; private set; }
    public int CustomerId { get; private set; }
    public decimal Balance { get; private set; }
    public CurrencyType Currency { get; private set; }
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
        if(number == null)
        {
            return 
        }
    }

    
}
