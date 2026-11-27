using System;
using System.Collections.Generic;

namespace Task_03_07
{
    interface IAirplane_flight
    {
        int count { get; set; }
        void Count();
    }

    class Person
    {
        public string Name { get; set; }
        public string Destination { get; set; }
        public string Departure_date { get; set; }

        public Person(string name, string destination, string departureDate)
        {
            Name = name;
            Destination = destination;
            Departure_date = departureDate;
        }

        public override string ToString()
        {
            return Name + " -> " + Destination + ", " + Departure_date;
        }
    }

    class Paris<T> : IAirplane_flight where T : Person
    {
        private List<T> list = new List<T>();

        public int count
        {
            get { return list.Count; }
            set
            {
                if (value != list.Count)
                {
                    throw new InvalidOperationException("count не може да се променя ръчно.");
                }
            }
        }

        public void Add(T person)
        {
            if (person.Destination == "Paris")
            {
                list.Add(person);
            }
            else
            {
                Console.WriteLine("Непозната дестинация за Paris: " + person.Destination + " (" + person.Name + " не е добавен)");
            }
        }

        public T this[int index]
        {
            get { return list[index]; }
        }

        public void Count()
        {
            Console.WriteLine("Брой пътници за Paris: " + list.Count);
        }
    }

    class Milano<T> : IAirplane_flight where T : Person
    {
        private List<T> list = new List<T>();

        public int count
        {
            get { return list.Count; }
            set
            {
                if (value != list.Count)
                {
                    throw new InvalidOperationException("count не може да се променя ръчно.");
                }
            }
        }

        public void Add(T person)
        {
            if (person.Destination == "Milano")
            {
                list.Add(person);
            }
            else
            {
                Console.WriteLine("Непозната дестинация за Milano: " + person.Destination + " (" + person.Name + " не е добавен)");
            }
        }

        public T this[int index]
        {
            get { return list[index]; }
        }

        public void Count()
        {
            Console.WriteLine("Брой пътници за Milano: " + list.Count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paris<Person> paris = new Paris<Person>();
            Milano<Person> milano = new Milano<Person>();

            paris.Count();
            milano.Count();
            Console.WriteLine();

            paris.Add(new Person("Иван Петров", "Paris", "2026-12-01"));
            paris.Add(new Person("Мария Георгиева", "Paris", "2026-12-05"));
            milano.Add(new Person("Георги Димитров", "Milano", "2026-12-03"));

            paris.Add(new Person("Стефан Илиев", "London", "2026-12-07"));
            milano.Add(new Person("Анна Колева", "Paris", "2026-12-09"));
            Console.WriteLine();

            Console.WriteLine("Пътници за Paris:");
            for (int i = 0; i < paris.count; i++)
            {
                Console.WriteLine("  " + paris[i]);
            }
            paris.Count();
            Console.WriteLine();

            Console.WriteLine("Пътници за Milano:");
            for (int i = 0; i < milano.count; i++)
            {
                Console.WriteLine("  " + milano[i]);
            }
            milano.Count();
            Console.WriteLine();

            paris.Count();
            milano.Count();
            Console.WriteLine();

            try
            {
                paris.count = 10;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Грешка: " + e.Message);
            }
        }
    }
}
