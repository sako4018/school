using Vacation.Models;
using Vacation.Views;

class Controller
{
    public void Run()
    {
        View view = new View();
        view.GetValues();
        Model model = new Model(view.Money, view.Season);

        if (model.IsValid())
        {
            decimal spent = model.Calculate();
            view.ShowVal(model.Place, spent);
        }
        else
        {
            view.ShowError();
        }
    }
}
