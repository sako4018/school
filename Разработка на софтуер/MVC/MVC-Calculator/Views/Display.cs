using MVC_Calculator.Models;

namespace MVC_Calculator.Views;
public class Display
{
    public decimal Amount {get;  set;}
    public decimal TipPercentage {get;  set;}
    public decimal TipAmount {get;  set;}
    public decimal TotalAmount {get;  set;}

    Tip tip = new Tip();
    public void GetValues()
    {
        Console.Write("Enter amount: ");
        Amount = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter tip percentage: ");
        TipPercentage = Convert.ToDecimal(Console.ReadLine());
    }
    public void ShowVal(decimal tipAmount, decimal totalAmount)
    {
        TipAmount = tipAmount;
        TotalAmount = totalAmount;
        Console.WriteLine($"Tip amount: {TipAmount:F2}");
        Console.WriteLine($"Total amount: {TotalAmount:F2}");
    }
}