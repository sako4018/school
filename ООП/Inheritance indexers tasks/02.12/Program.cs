using System;
using System.Collections.Generic;

namespace Task_02_12
{
    class Ticket
    {
        public string PerformanceName { get; set; }
        public decimal Price { get; set; }
        protected string name;
        protected int age;

        public Ticket(string performanceName, decimal price)
        {
            PerformanceName = performanceName;
            Price = price;
        }

        public virtual decimal GetPrice()
        {
            return Price;
        }

        public virtual string GetTicketInfo()
        {
            return $"Regular ticket price: {GetPrice():F2} лв., Performance: {PerformanceName}";
        }
    }

    class Discount_ticket : Ticket
    {
        public decimal Discount { get; } = 0.5m;

        public Discount_ticket(string performanceName, decimal price, string name, int age) : base(performanceName, price)
        {
            this.name = name;
            this.age = age;
        }

        public override decimal GetPrice()
        {
            if (age < 20 || age > 60)
            {
                return Price * Discount;
            }
            return Price;
        }

        public override string GetTicketInfo()
        {
            return $"Discount ticket price: {GetPrice():F2} лв., Name: {name}, Age: {age}, Performance: {PerformanceName}";
        }
    }

    class Program
    {
        static string ReadLine()
        {
            string line = Console.ReadLine();
            if (line == null)
            {
                return "exit";
            }
            return line.Trim();
        }

        static void Main(string[] args)
        {
            Dictionary<string, decimal> performances = new Dictionary<string, decimal>
            {
                {"Hamlet", 20.0m},
                {"Romeo and Juliet", 18.5m},
                {"Macbeth", 22.0m},
                {"Othello", 19.5m},
                {"King Lear", 21.0m}
            };

            List<Ticket> tickets = new List<Ticket>();

            while (true)
            {
                Console.WriteLine("Available performances:");
                foreach (string performance in performances.Keys)
                {
                    Console.WriteLine($"- {performance}");
                }

                Console.Write("Performance? (or type 'exit' to quit): ");
                string performanceName = ReadLine();
                if (performanceName == "exit")
                {
                    break;
                }
                if (!performances.ContainsKey(performanceName))
                {
                    Console.WriteLine("Unknown performance. Try again.");
                    Console.WriteLine();
                    continue;
                }

                Console.Write("Ticket type? (regular or discount): ");
                string type = ReadLine();
                decimal price = performances[performanceName];

                if (type == "regular")
                {
                    Ticket ticket = new Ticket(performanceName, price);
                    tickets.Add(ticket);
                    Console.WriteLine(ticket.GetTicketInfo());
                }
                else if (type == "discount")
                {
                    Console.Write("Name: ");
                    string name = ReadLine();
                    while (name == "")
                    {
                        Console.Write("Name cannot be empty. Name: ");
                        name = ReadLine();
                    }

                    Console.Write("Age: ");
                    int age;
                    while (!int.TryParse(ReadLine(), out age) || age < 0)
                    {
                        Console.Write("Invalid age. Age: ");
                    }

                    Ticket ticket = new Discount_ticket(performanceName, price, name, age);
                    tickets.Add(ticket);
                    Console.WriteLine(ticket.GetTicketInfo());
                }
                else
                {
                    Console.WriteLine("Unknown ticket type. Try again.");
                }
                Console.WriteLine();
            }

            decimal total = 0;
            foreach (Ticket ticket in tickets)
            {
                total = total + ticket.GetPrice();
            }
            Console.WriteLine($"Tickets sold: {tickets.Count}, total: {total:F2} лв.");
        }
    }
}
