using System;

namespace Task_02_12
{
    class Ticket
    {
        public string Title {get; private set;}
        public decimal Price {get; private set;}
        protected string name;
        protected int age;
        public Ticket(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }
        public Ticket() : this("Unknown", 0)
        {
            
        }
        public virtual decimal GetPrice()
        {
            return this.Price;
        }
        public virtual string GetTicketInfo()
        {
            return $"Title: {Title}, Price: {Price}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
