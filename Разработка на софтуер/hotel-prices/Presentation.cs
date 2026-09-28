using System;
using System.Collections.Generic;
using System.Linq;
public class Presentation
{
    private readonly Buisness buisness = new Buisness();

    public static void Main()
    {
        Console.WriteLine("Enter the month of your stay (May, June, July, August, September, October):");
        string month = Console.ReadLine();
    }
}