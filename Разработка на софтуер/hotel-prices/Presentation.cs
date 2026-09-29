using System;
using System.Collections.Generic;
using System.Linq;
public class Presentation
{
    Buisness buisness = new Buisness();

    public void Present()
    {
        //
        Console.Write("Enter the month of your stay (May, June, July, August, September, October): ");
        string month = Console.ReadLine().Trim();
        Console.Write("Enter the type of accommodation (Studio, Apartment): ");
        string type = Console.ReadLine().Trim();
        Console.Write("Enter the days of your stay: ");
        int days = int.Parse(Console.ReadLine());



        decimal price = buisness.CalculatePrice(month, type, days);
        Console.WriteLine($"The price for your stay is: ${price:F2}");

    }
}