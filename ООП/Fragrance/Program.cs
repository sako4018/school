using System;

namespace Fragrance
{
    interface IFragrance
    {
        string GetAroma();
        int GetLongevity();
    }
    abstract class Parfume
    {
        //brand name price konstructor PrintInfo  public abstract string GetCategory
        public string Brand{get;private set;}
        public string Name{get;private set;}
        public decimal Price{get;private set;}
        protected Parfume(string brand, string name ,decimal price)
        {
            Brand = brand;
            Name = name;
            Price = price;
            if(brand == "" || name == ""|| brand == null || name == null)
            {
                throw new ArgumentNullException("No brand or name");
            }
            if(!(price >= 0 || price <= decimal.MaxValue))
            {
                throw new ArgumentNullException("No price");
            }
        }
        
        public void PrintInfo()
        {
            System.Console.WriteLine($"Brand: {Brand}, Name: {Name}, Price: {Price}");
        }
        public abstract string GetCategory();
    }

    class EauDeParfum : Parfume
    {
        
    }

    class EauDeParfum : Parfume
    {
        int OilPercentage{get;set;}
        public void GetCategory()
        {
            if(OilPercentage < 15)
            {
                System.Console.WriteLine("Light");
            }
            else if (OilPercentage >15 && OilPercentage < 20)
            {
                System.Console.WriteLine("Medium");
            }
            else if (OilPercentage > 20)
            {
                System.Console.WriteLine("Intense");
            }
        }
    }
    class EauDeToilette : Parfume
    {
        bool IsLimitedEdition()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
