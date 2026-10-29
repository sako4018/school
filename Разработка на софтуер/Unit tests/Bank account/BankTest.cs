using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BankTests
{
    [TestMethod]
    public void Deposit_TwoAmounts_BalanceIs150()
    {
        BankAccount account = new BankAccount();
        account.Deposit(125m);
        account.Deposit(25m);
        Assert.AreEqual(150m, account.Balance);
    }
    [TestMethood]
    public void Constructor_BalanceIs2000()
    {
        BankAccount account = new BankAccount(2000m);
        Assert.AreEqual(150m, account.Balance);
    }
    
}