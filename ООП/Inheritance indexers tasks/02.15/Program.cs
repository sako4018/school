using System;
using System.Collections.Generic;

namespace Task_02_15
{
    class FoodItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        protected string Type;

        public FoodItem(string name, decimal price, int calories, string type)
        {
            Name = name;
            Price = price;
            Calories = calories;
            Type = type;
        }

        public virtual decimal GetPrice()
        {
            return Price;
        }

        public virtual string GetInfo()
        {
            return $"{Name} ({Type}), {Calories} kcal, {GetPrice():F2} лв.";
        }
    }

    class MainCourse : FoodItem
    {
        bool isVegan;

        public MainCourse(string name, decimal price, int calories, bool isVegan) : base(name, price, calories, "Основно")
        {
            this.isVegan = isVegan;
        }

        public override decimal GetPrice()
        {
            if (isVegan)
            {
                return Price * 0.90m;
            }
            return Price;
        }

        public override string GetInfo()
        {
            string vegan = isVegan ? "веган" : "не е веган";
            return $"{base.GetInfo()}, {vegan}";
        }
    }

    class Dessert : FoodItem
    {
        bool hasSugar;

        public Dessert(string name, decimal price, int calories, bool hasSugar) : base(name, price, calories, "Десерт")
        {
            this.hasSugar = hasSugar;
        }

        public override decimal GetPrice()
        {
            if (!hasSugar)
            {
                return Price * 1.15m;
            }
            return Price;
        }

        public override string GetInfo()
        {
            string sugar = hasSugar ? "със захар" : "без захар";
            return $"{base.GetInfo()}, {sugar}";
        }
    }

    class Drink : FoodItem
    {
        bool isAlcoholic;

        public Drink(string name, decimal price, int calories, bool isAlcoholic) : base(name, price, calories, "Напитка")
        {
            this.isAlcoholic = isAlcoholic;
        }

        public override decimal GetPrice()
        {
            if (isAlcoholic)
            {
                return Price * 1.20m;
            }
            return Price;
        }

        public override string GetInfo()
        {
            string alcohol = isAlcoholic ? "алкохолна" : "безалкохолна";
            return $"{base.GetInfo()}, {alcohol}";
        }
    }

    class Order
    {
        public string CustomerName { get; set; }
        public List<FoodItem> Items { get; set; } = new List<FoodItem>();

        public void AddItem(FoodItem item)
        {
            Items.Add(item);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (FoodItem item in Items)
            {
                total = total + item.GetPrice();
            }
            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"Поръчка на {CustomerName}:");
            foreach (FoodItem item in Items)
            {
                Console.WriteLine($"  {item.GetInfo()}");
            }
            Console.WriteLine($"Обща сума: {GetTotalPrice():F2} лв.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, FoodItem> menu = new Dictionary<string, FoodItem>(StringComparer.OrdinalIgnoreCase);
            menu.Add("Burger", new MainCourse("Burger", 12.00m, 750, false));
            menu.Add("Vegan Bowl", new MainCourse("Vegan Bowl", 10.00m, 450, true));
            menu.Add("Cheesecake", new Dessert("Cheesecake", 7.00m, 400, true));
            menu.Add("Fruit Cake", new Dessert("Fruit Cake", 10.00m, 250, false));
            menu.Add("Cola", new Drink("Cola", 3.00m, 140, false));
            menu.Add("Beer", new Drink("Beer", 10.00m, 150, true));

            Order order = new Order();

            Console.Write("Име: ");
            string customer = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(customer))
            {
                Console.Write("Името не може да е празно. Име: ");
                customer = Console.ReadLine();
            }
            order.CustomerName = customer.Trim();

            Console.WriteLine("Меню:");
            foreach (FoodItem item in menu.Values)
            {
                Console.WriteLine($"  {item.GetInfo()}");
            }

            while (true)
            {
                Console.Write("Ястие (или 'стоп'): ");
                string choice = Console.ReadLine();
                if (choice == null || choice.Trim().ToLower() == "стоп")
                {
                    break;
                }
                choice = choice.Trim();
                if (menu.ContainsKey(choice))
                {
                    order.AddItem(menu[choice]);
                    Console.WriteLine($"Добавено: {menu[choice].Name}");
                }
                else
                {
                    Console.WriteLine("Няма такова ястие в менюто.");
                }
            }

            Console.WriteLine();
            order.PrintOrderDetails();
        }
    }
}
