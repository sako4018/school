namespace Vacation.Models;

// Model - тук са данните и изчисленията. Тук няма Console.WriteLine!
public class Model
{
    public decimal Money { get; private set; }
    public string Season { get; private set; }
    public string Place { get; private set; }   // къде ще почиваме (пълни се след Calculate)

    public Model(decimal money, string season)
    {
        Money = money;
        Season = season;
        Place = "";
    }

    public Model() : this(0, "unknown")
    {
    }

    // Проверява дали парите и сезонът са правилни
    public bool IsValid()
    {
        if ((Money >= 10 && Money <= 5000) && (Season.ToLower() == "winter" || Season.ToLower() == "summer"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Връща колко пари ще се похарчат и запомня къде (Place)
    public decimal Calculate()
    {
        if (Season.ToLower() == "summer" && (Money >= 10 && Money <= 100))
        {
            Place = "Camp at summer in Bulgaria";
            return Money * 30 / 100;
        }
        else if (Season.ToLower() == "winter" && (Money >= 10 && Money <= 100))
        {
            Place = "Hotel at winter in Bulgaria";
            return Money * 70 / 100;
        }
        else if (Season.ToLower() == "summer" && (Money > 100 && Money <= 1000))
        {
            Place = "Camp at summer in Bulgaria";
            return Money * 40 / 100;
        }
        else if (Season.ToLower() == "winter" && (Money > 100 && Money <= 1000))
        {
            Place = "Hotel at winter in Bulgaria";
            return Money * 80 / 100;
        }
        else if (Season.ToLower() == "summer" && (Money > 1000 && Money <= 5000))
        {
            Place = "Camp at summer in Bulgaria";
            return Money * 90 / 100;
        }
        else if (Season.ToLower() == "winter" && (Money > 1000 && Money <= 5000))
        {
            Place = "Hotel at winter in Bulgaria";
            return Money * 90 / 100;
        }
        else
        {
            return 0;
        }
    }
}
