using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class BankTests
{
    [Test]
    public void Deposit_TwoAmounts_BalanceIs150()
    {
        BankAccount account = new BankAccount();
        account.Deposit(125m);
        account.Deposit(25m);
        Assert.That(account.Balance, Is.EqualTo(150m));
    }
    [Test]
    public void Constructor_BalanceIs2000()
    {
        BankAccount account = new BankAccount(2000m);
        Assert.That(account.Balance, Is.EqualTo(2000m));
    }

}