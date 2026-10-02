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
    public bool IsValid()
    {
        if ((Amount <= 0 || TipPercentage >= 100000) && (TipPercentage < 0 || TipPercentage > 100))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public decimal CalculateTip()
    {
        return Amount * (TipPercentage / 100);
    }

    public decimal CalculateTotal()
    {
        decimal total = Amount + CalculateTip();
        return total;
    }
}
