using System.Security.Cryptography.Xml;

public class Display
{
    Model model = new Model();
    public decimal VegetablesPrice{get;private set;}
    public decimal FruitsPrice{get;private set;}
    public int VegetablesWeight{get;private set;}
    public int FruitsWeight{get;private set;}
    public void GetValues()
    {
        Console.Write("Enter vegetables price/kg: ");
        VegetablesPrice = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter vegetables weight: ");
        VegetablesWeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fruits price/kg: ");
        FruitsPrice = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter fruirs weight: ");
        VegetablesWeight = Convert.ToInt32(Console.ReadLine());
    }

    public void ShowVal()
    {
        System.Console.Write("Total cost: ");
        model.CalculateInEuro();
    }
}