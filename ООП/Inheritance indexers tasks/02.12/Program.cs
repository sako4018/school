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
    class DiscountedTicket : Ticket
    {
        public decimal Discount { get; set;} = 0.5m;
        public DiscountedTicket(string title, decimal price, decimal discount) : base(title, price)
        {
            this.Discount = discount;
        }
        public override decimal GetPrice()
        {
            return this.Price - (this.Price * this.Discount);
        }
        public override string GetTicketInfo()
        {
            return $"Title: {Title}, Price: {GetPrice()}, Discount: {Discount}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
