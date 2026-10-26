using SwimmingPool.Models;
class Controller
{
    public void Run()
    {
        View view = new View();
        view.GetValues();

        Model model = new Model(view.Volume, view.P1, view.P2, view.Hours);
        if (model.IsValid())
        {
            view.ShowVal();
        }
       
    }
}