class Controler
{
    public void Run()
    {
        View view = new View();
        view.GetValues();
        Model model = new Model(view.Row, view.Col, view.Type);

        if (model.IsValid())
        {
            double income = model.Calculate();
            view.Display();
        }
        else
        {
            view.ShowError();
        }
    }
}