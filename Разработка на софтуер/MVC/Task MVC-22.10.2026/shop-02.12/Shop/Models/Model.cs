namespace Shop.Models;

public class Model
{
    public string Product { get; private set; }
    public string City { get; private set; }
    public double Quantity { get; private set; }

    public Model(string product, string city, double quantity)
    {
        Product = product;
        City = city;
        Quantity = quantity;
    }

    public Model() : this("", "", 0)
    {
    }

    public bool IsValid()
    {
        bool productOk = Product == "coffee" || Product == "water" || Product == "juice" ||
                         Product == "sweets" || Product == "peanuts";
        bool cityOk = City == "Sofia" || City == "Plovdiv" || City == "Varna";

        if (productOk && cityOk && Quantity >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double Prices()
    {
        if (City == "Sofia")
        {
            if (Product == "coffee") return 0.50;
            if (Product == "water") return 0.80;
            if (Product == "juice") return 1.20;
            if (Product == "sweets") return 1.45;
            if (Product == "peanuts") return 1.60;
        }
        if (City == "Plovdiv")
        {
            if (Product == "coffee") return 0.40;
            if (Product == "water") return 0.70;
            if (Product == "juice") return 1.15;
            if (Product == "sweets") return 1.30;
            if (Product == "peanuts") return 1.50;
        }
        if (City == "Varna")
        {
            if (Product == "coffee") return 0.45;
            if (Product == "water") return 0.70;
            if (Product == "juice") return 1.10;
            if (Product == "sweets") return 1.35;
            if (Product == "peanuts") return 1.55;
        }
        return 0;
    }

    public double Calculate()
    {
        double price = Prices() * Quantity;
        return Math.Round(price, 10);
    }
}
