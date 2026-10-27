using Shop.Models;
using Shop.Views;

class Controller
{
    public void Run()
    {
        View view = new View();
        view.GetValues();
        Model model = new Model(view.Product, view.City, view.Quantity);

        if (model.IsValid())
        {
            double price = model.Calculate();
            view.ShowVal(price);
        }
        else
        {
            view.ShowError();
        }
    }
}
