using System;
using System.Collections.Generic;

namespace Fragrance
{
    interface IFragrance
    {
        string GetAroma();
        int GetLongevity();
    }

    abstract class Perfume
    {
        public string Brand { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        protected Perfume(string brand, string name, double price)
        {
            // Първо проверяваме, после записваме
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Марката и името не могат да са празни.");
            }
            if (price < 0 || double.IsNaN(price) || double.IsInfinity(price))
            {
                throw new ArgumentException("Цената трябва да е краен неотрицателен брой.");
            }
            Brand = brand;
            Name = name;
            Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Name: {Name}, Price: {Price:F2}");
        }

        public abstract string GetCategory();
    }

    class EauDeParfum : Perfume, IFragrance
    {
        private int oilPercentage;
        private string aroma;
        private int longevity;

        public int OilPercentage
        {
            get { return oilPercentage; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("OilPercentage трябва да е от 0 до 100.");
                }
                oilPercentage = value;
            }
        }

        public EauDeParfum(string brand, string name, double price, int oilPercentage, string aroma, int longevity)
            : base(brand, name, price)
        {
            if (longevity < 1 || longevity > 24)
            {
                throw new ArgumentException("Трайността трябва да е от 1 до 24 часа.");
            }
            OilPercentage = oilPercentage;
            this.aroma = aroma;
            this.longevity = longevity;
        }

        public override string GetCategory()
        {
            if (OilPercentage < 15)
            {
                return "Лек";
            }
            else if (OilPercentage <= 20)
            {
                return "Среден";
            }
            else
            {
                return "Интензивен";
            }
        }

        public string GetAroma()
        {
            return aroma;
        }

        public int GetLongevity()
        {
            return longevity;
        }
    }

    class EauDeToilette : Perfume, IFragrance
    {
        public bool IsLimitedEdition { get; set; }
        private string aroma;
        private int longevity;

        public EauDeToilette(string brand, string name, double price, bool isLimitedEdition, string aroma, int longevity)
            : base(brand, name, price)
        {
            if (longevity < 1 || longevity > 24)
            {
                throw new ArgumentException("Трайността трябва да е от 1 до 24 часа.");
            }
            IsLimitedEdition = isLimitedEdition;
            this.aroma = aroma;
            this.longevity = longevity;
        }

        public override string GetCategory()
        {
            if (IsLimitedEdition)
            {
                return "Лимитирана серия";
            }
            return "Стандартен";
        }

        public string GetAroma()
        {
            return aroma;
        }

        public int GetLongevity()
        {
            return longevity;
        }
    }

    // Тестерът не наследява Perfume, затова няма цена
    class PerfumeTester : IFragrance
    {
        public Guid Id { get; private set; }
        public string Notes { get; private set; }
        private int longevity;

        public PerfumeTester(string notes, int longevity)
        {
            if (longevity < 1 || longevity > 3)
            {
                throw new ArgumentException("Трайността на тестера трябва да е от 1 до 3 часа.");
            }
            Id = Guid.NewGuid();
            Notes = notes;
            this.longevity = longevity;
        }

        public string GetAroma()
        {
            return Notes;
        }

        public int GetLongevity()
        {
            return longevity;
        }

        public void PrintTesterInfo()
        {
            Console.WriteLine($"Tester Id: {Id}, Notes: {Notes}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IFragrance> fragrances = new List<IFragrance>();
            fragrances.Add(new EauDeParfum("Dior", "Sauvage", 180.00, 22, "Бергамот и амбър", 12));
            fragrances.Add(new EauDeParfum("Chanel", "Bleu", 150.50, 15, "Цитруси и дървесни нотки", 9));
            fragrances.Add(new EauDeToilette("Versace", "Eros", 95.00, false, "Мента и ванилия", 8));
            fragrances.Add(new EauDeToilette("Hugo Boss", "Bottled", 80.00, true, "Ябълка и канела", 10));
            fragrances.Add(new PerfumeTester("Свежи цитруси", 2));

            // 6. Демонстрация
            Console.WriteLine("=== Всички аромати ===");
            foreach (IFragrance fragrance in fragrances)
            {
                Console.WriteLine(fragrance.GetAroma());
                Console.WriteLine(fragrance.GetLongevity());
                if (fragrance is Perfume perfume)
                {
                    perfume.PrintInfo();
                    Console.WriteLine(perfume.GetCategory());
                }
                if (fragrance is PerfumeTester tester)
                {
                    tester.PrintTesterInfo();
                }
                Console.WriteLine();
            }

            // 7. Сортиране по трайност (на копие, с пряка сортировка с два цикъла)
            List<IFragrance> sorted = new List<IFragrance>(fragrances);
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                for (int j = 0; j < sorted.Count - 1 - i; j++)
                {
                    if (sorted[j].GetLongevity() > sorted[j + 1].GetLongevity())
                    {
                        IFragrance temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("=== Сортирани по трайност ===");
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i].GetLongevity() + " ч. - " + sorted[i].GetAroma());
            }
            Console.WriteLine();

            // Филтър: трайност над 10 часа (точно 10 не влиза)
            Console.WriteLine("=== Трайност над 10 часа ===");
            int longCount = 0;
            for (int i = 0; i < fragrances.Count; i++)
            {
                if (fragrances[i].GetLongevity() > 10)
                {
                    Console.WriteLine(fragrances[i].GetLongevity() + " ч. - " + fragrances[i].GetAroma());
                    longCount++;
                }
            }
            if (longCount == 0)
            {
                Console.WriteLine("Няма данни");
            }
            Console.WriteLine();

            // Средна цена само на EauDeParfum
            double sum = 0;
            int parfumCount = 0;
            for (int i = 0; i < fragrances.Count; i++)
            {
                if (fragrances[i] is EauDeParfum edp)
                {
                    sum = sum + edp.Price;
                    parfumCount++;
                }
            }
            Console.WriteLine("=== Средна цена на EauDeParfum ===");
            if (parfumCount == 0)
            {
                Console.WriteLine("Няма данни");
            }
            else
            {
                Console.WriteLine((sum / parfumCount).ToString("F2"));
            }
            Console.WriteLine();

            // Най-висок OilPercentage (при равни се извеждат всички)
            int maxOil = -1;
            for (int i = 0; i < fragrances.Count; i++)
            {
                if (fragrances[i] is EauDeParfum edp && edp.OilPercentage > maxOil)
                {
                    maxOil = edp.OilPercentage;
                }
            }
            Console.WriteLine("=== Най-висок OilPercentage ===");
            if (maxOil == -1)
            {
                Console.WriteLine("Няма данни");
            }
            else
            {
                for (int i = 0; i < fragrances.Count; i++)
                {
                    if (fragrances[i] is EauDeParfum edp && edp.OilPercentage == maxOil)
                    {
                        Console.WriteLine(edp.Brand + " " + edp.Name + " - " + maxOil + "%");
                    }
                }
            }
            Console.WriteLine();

            // 8. Самопроверка на категориите: 14, 15, 20, 21
            Console.WriteLine("=== Самопроверка на категориите ===");
            int[] percents = { 14, 15, 20, 21 };
            for (int i = 0; i < percents.Length; i++)
            {
                EauDeParfum test = new EauDeParfum("Test", "Test", 1, percents[i], "тест", 5);
                Console.WriteLine(percents[i] + "% -> " + test.GetCategory());
            }
        }
    }
}
