namespace MVC_Calculator.Models;

public class Tip
{
    public decimal Amount { get; private set; }
    public decimal TipPercentage { get; private set; }

    public Tip(decimal amount, decimal tipPercentage)
    {
        Amount = amount;
        TipPercentage = tipPercentage;
    }
    public Tip()
    {
        Amount = 0;
        TipPercentage = 0;
    }

}
