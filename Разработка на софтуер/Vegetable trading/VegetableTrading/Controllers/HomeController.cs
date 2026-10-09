class Controler
{
    public void Run()
    {
        Display display = new Display();
        display.GetValues();
        Model model = new Model();

        if (model.IsValid())
        {
            display.ShowVal(model.CalculateInEuro);
            
        }

    }
}