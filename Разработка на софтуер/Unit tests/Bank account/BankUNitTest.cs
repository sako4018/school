using NUnit.Framework;

[TestFixture]
public class BankTest
{
    private BankAccount account;
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        TestContext.Progress.WriteLine("OneTimeSetUp");
    }
    [SetUp]
    public void SetUp()
    {
        account = new BankAccount();
    }
    [TearDown]
    public void TearDown()
    {
        TestContext.Progress.WriteLine("TearDown");
    }
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        TestContext.Progress.WriteLine("OneTimeTearDown");
    }
    [Test]
    [Category("Constructor")]
    public void Constructor_NoParameters_BalanceIs0()
    {
        Assert.That(account, Is.Not.Null);
        Assert.That(account.Balance, Is.EqualTo(0m));
    }
    [Test]
    [Category("Constructor")]
    public void Constructor_Balance_Is2000()
    {
        BankAccount rich = new BankAccount(2000m);
        Assert.That(rich.Balance, Is.EqualTo(2000m));
    }
    [Test]
    [Category("Deposit")]
    public void Constructor_NegativeBalance_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new BankAccount(-1m));
    }
    [Test]
    [Category("Deposit")]
    public void Deposit_50_BalanceIs50()
    {
        account.Deposit(50m);
        Assert.That(account.Balance, Is.EqualTo(50m));
        Assert.That(account.Balance, Is.GreaterThan(0m));
    }
    [Test]
    [Category("Deposit")]
    public void Deposit_TwoAmounts_BalanceIs150()
    {
        account.Deposit(125m);
        account.Deposit(25m);
        Assert.That(account.Balance, Is.EqualTo(150m));
    }
    [TestCase(0)]
    [TestCase(-5)]
    [Category("Deposit")]
    public void Deposit_InvalidAmount_ThrowsArgumentException(int amount)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => account.Deposit(amount));
    }
    [TestCase(10, 20, 30)]
    [TestCase(125, 25, 150)]
    [Category("Deposit")]
    public void Deposit_TwoAmounts_BalanceIsSum(int first, int second, int expected)
    {
        account.Deposit(first);
        account.Deposit(second);
        Assert.That(account.Balance, Is.EqualTo(expected));
    }
    [Test]
    [Category("withdraw")]
    public void Withdrow_MoreThanBalance_ThrowsAndBalanceIsUnchanged()
    {
        account.Deposit(50m);
        Assert.That(
            () => account.WithDraw(80m),
            Throws.TypeOf<InvalidOperationException>().With.Message.EqualTo("Insufficient funds for this withdrawal")
        );
        Assert.That(account.Balance, Is.EqualTo(50m));
    }
    [Test]
    [Category("Balance")]
    public void IsEmpty_NewAccount_IsTrue()
    {
        Assert.That(account.IsEmpty, Is.True);
    }
    [Test]
    [Category("Balance")]
    public void IsEmpty_AfterDeposit_IsFalse()
    {
        account.Deposit(10m);
        Assert.That(account.IsEmpty, Is.False);
    }
    [Test]
    [Ignore("")]
    public void Interest_SPercent_AddToBalance()
    {
        Assert.Fail();
    }


}