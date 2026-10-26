using SwimmingPool.Models;
class View
{
    Model model = new Model();
    public int Volume{get;private set;}
    public int P1{get; private set;}
    public int P2{get; private set;}
    public double Hours{get; private set;}


    public void GetValues()
    {
        System.Console.WriteLine("Enter Volume: ");
        Volume = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Pipe 1: ");
        P1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Pipe 2: ");
        P2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Hours");
        Hours = Convert.ToDouble(Console.ReadLine());

    }
    public void ShowVal()
    {
        System.Console.WriteLine(model.Calculate);
    }
}