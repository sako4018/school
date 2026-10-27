using OnTime.Models;
using OnTime.Views;

class Controller
{
    public void Run()
    {
        View view = new View();
        view.GetValues();
        Model model = new Model(view.ExamHour, view.ExamMinute, view.ArriveHour, view.ArriveMinute);

        if (model.IsValid())
        {
            string status = model.Calculate();
            view.ShowVal(status, model.Details);
        }
        else
        {
            view.ShowError();
        }
    }
}
