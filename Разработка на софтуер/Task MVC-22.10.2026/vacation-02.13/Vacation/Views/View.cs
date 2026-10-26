namespace Vacation.Views;

public class View
{
    public decimal Money { get; set; }
    public string Season { get; set; }
    public string Place { get; set; }
    public decimal Spent { get; set; }

    public void GetValues()
    {
        Console.Write("Budget (money): ");
        Money = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Season (winter/summer): ");
        Season = Console.ReadLine();
    }

    public void ShowVal(string place, decimal spent)
    {
        Place = place;
        Spent = spent;
        Console.WriteLine($"{Place}: {Spent}");
    }

    public void ShowError()
    {
        Console.WriteLine("Invalid input!");
    }
}
