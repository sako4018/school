namespace Shop.Views;

public class View
{
    public string Product { get; set; }
    public string City { get; set; }
    public double Quantity { get; set; }

    public void GetValues()
    {
        Console.Write("Product: ");
        Product = Console.ReadLine();
        Console.Write("City: ");
        City = Console.ReadLine();
        Console.Write("Quantity: ");
        Quantity = Convert.ToDouble(Console.ReadLine());
    }

    public void ShowVal(double price)
    {
        Console.WriteLine(price);
    }

    public void ShowError()
    {
        Console.WriteLine("Invalid input!");
    }
}
