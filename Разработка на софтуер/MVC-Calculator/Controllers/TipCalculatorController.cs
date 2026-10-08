using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using MVC_Calculator.Models;
using MVC_Calculator.Views;

class Controler
{
    public void Run()
    {
        Display display = new Display();
        display.GetValues();
        Tip tip = new Tip(display.Amount, display.TipPercentage);
        /*
        if (tip.IsValid())
        {
            display.TipAmount = tip.CalculateTip();
            display.TotalAmount = tip.CalculateTotal();
        }
        */
        if (tip.IsValid())
        {
            display.ShowVal(tip.CalculateTip(), tip.CalculateTotal());
        }

    }
}