using System;
using System.Collections.Generic;

namespace Task_03_09
{
    interface Bank_Account
    {
        void deposit(double increment);
        void withdraw(double decrement);
    }

    class Person : Bank_Account
    {
        public double money;
        public string name;

        public Person(string name, double money)
        {
            if (double.IsNaN(money) || double.IsInfinity(money) || money < 0)
            {
                throw new ArgumentException("Началният баланс трябва да е краен и неотрицателен.");
            }
            this.name = name;
            this.money = money;
        }

        private bool IsValidAmount(double amount)
        {
            if (double.IsNaN(amount) || double.IsInfinity(amount) || amount <= 0)
            {
                Console.WriteLine(name + ": невалидна сума " + amount);
                return false;
            }
            return true;
        }

        public void deposit(double increment)
        {
            if (!IsValidAmount(increment))
            {
                return;
            }
            money = money + increment;
        }

        public void withdraw(double decrement)
        {
            if (!IsValidAmount(decrement))
            {
                return;
            }
            if (decrement > money)
            {
                Console.WriteLine(name + ": недостатъчна наличност за теглене на " + decrement.ToString("F2"));
                return;
            }
            money = money - decrement;
        }

        public override string ToString()
        {
            return name + ": " + money.ToString("F2");
        }
    }

    class Generic<T>
    {
        private List<T> list = new List<T>();

        public int Count
        {
            get { return list.Count; }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T this[int index]
        {
            get { return list[index]; }
        }

        public void PrintAll()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Generic<Person> clients = new Generic<Person>();

            clients.Add(new Person("Иван Петров", 100));
            clients.Add(new Person("Мария Георгиева", 2500.50));
            clients.Add(new Person("Георги Димитров", 0));

            Console.WriteLine("Клиенти в началото:");
            clients.PrintAll();
            Console.WriteLine();

            clients[0].deposit(50);
            clients[0].withdraw(30);
            Console.WriteLine("След deposit(50) и withdraw(30):");
            Console.WriteLine(clients[0]);
            Console.WriteLine();

            Console.WriteLine("Невалидни операции:");
            clients[0].withdraw(200);
            clients[0].deposit(0);
            clients[0].withdraw(-10);
            clients[0].deposit(double.NaN);
            clients[0].deposit(double.PositiveInfinity);
            Console.WriteLine(clients[0]);
            Console.WriteLine();

            clients[1].withdraw(500);
            Console.WriteLine("Всички клиенти накрая:");
            clients.PrintAll();
            Console.WriteLine("Общо клиенти: " + clients.Count);
        }
    }
}
