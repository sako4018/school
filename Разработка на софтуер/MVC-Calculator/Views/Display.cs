using MVC_Calculator.Models;

namespace MVC_Calculator.Views;
public class Display
{
    public decimal Amount {get; private set;}
    public decimal TipPercentage {get; private set;}
    public decimal TipAmount {get; private set;}
    public decimal TotalAmount {get; private set;}

    Tip tip = new Tip();
    public void GetValues()
    {
        Console.Write("Enter amount: ");
        Amount = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter tip percentage: ");
        TipPercentage = Convert.ToDecimal(Console.ReadLine());
    }
    public void ShowVal()
    {
        tip = new Tip(TotalAmount, TipAmount);
        if (tip.IsValid())
        {
            TipAmount = tip.CalculateTip();
            TotalAmount = tip.CalculateTotal();
            Console.WriteLine($"Tip amount: {TipAmount:F2}");
            Console.WriteLine($"Total amount: {TotalAmount:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid amount and tip percentage.");
        }
    }
}