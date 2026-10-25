class View
{
    Model model = new Model();
    public int Row{get;private set;}
    public int Col{get;private set;}
    public string Type{get;private set;}

    public void GetValues()
    {
        System.Console.WriteLine("Enter rows: ");
        int Row = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter columns: ");
        int Col = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter enter type: ");
        string type = Console.ReadLine();
    }


    public void Display()
    {
        model.Calculate();
    }

    public void ShowError()
    {
        System.Console.WriteLine("Invalid input!");
    }
}