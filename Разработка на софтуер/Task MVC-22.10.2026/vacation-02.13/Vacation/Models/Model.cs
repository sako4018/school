using System.Text;

class Model
{
    private decimal _money;
    private string _season;

    public decimal Money{get;private set;}
    public string Season{get;private set;}

    public Model(decimal money, string season)
    {
        Money = money;
        Season = season;
    }
    public Model():this(0, "unknown")
    {
        
    }
    public bool isValid()
    {
        if((Money >= 10 && Money <= 5000) && (Season.ToLower() == "winter" || Season.ToLower() == "summer"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public decimal Calculate()
    {
        if(Season.ToLower() == "summer" && (Money >= 10 && Money <= 100))
        {
            System.Console.WriteLine("Camp at summer in Bulgaria: ");
            return (30/100) * Money;
        }
        else if(Season.ToLower() == "winter" && (Money >= 10 && Money <= 100))
        {
            System.Console.WriteLine("Hotel at winter in Bulgaria: ");
            return (70/100) * Money;
        }



        else if (Season.ToLower() == "summer" && (Money > 100 && Money <= 1000))
        {
            System.Console.WriteLine("Camp at summer in Bulgaria: ");
            return (40/100) * Money;
        }
        else if(Season.ToLower() == "winter" && (Money > 100 && Money <= 1000))
        {
            System.Console.WriteLine("Hotel at winter in Bulgaria: ");
            return (80/100) * Money;
        }



        else if (Season.ToLower() == "summer" && (Money > 1000 && Money <= 5000))
        {
            System.Console.WriteLine("Camp at summer in Bulgaria: ");
            return (90/100) * Money;
        }
        else if(Season.ToLower() == "winter" && (Money > 1000 && Money <= 5000))
        {
            System.Console.WriteLine("Hotel at winter in Bulgaria: ");
            return (90/100) * Money;
        }


        else
        {
            return 0;
        }
    }
}