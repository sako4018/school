using MVC_Calculator.Models;
using MVC_Calculator.Views;

namespace MVC_Calculator;

class Program
{
    public static void Main(string[] args)
    {
        Controler controler = new Controler();
        controler.Run();
    }
}
