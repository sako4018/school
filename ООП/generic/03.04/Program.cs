using System;
using System.Collections.Generic;

namespace Task_03_04
{
    abstract class Animal
    {
        public int Count { get; private set; }

        protected Animal(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count", "Броят не може да е отрицателен.");
            }
            Count = count;
        }

        public abstract string Name { get; }

        public abstract double FoodGrams { get; }
    }

    class Bird : Animal
    {
        public Bird(int count) : base(count)
        {
        }

        public override string Name
        {
            get { return "Bird"; }
        }

        public override double FoodGrams
        {
            get { return Count * 453.5; }
        }
    }

    class Cow : Animal
    {
        public Cow(int count) : base(count)
        {
        }

        public override string Name
        {
            get { return "Cow"; }
        }

        public override double FoodGrams
        {
            get { return Count * 2000.0; }
        }
    }

    class Rabbit : Animal
    {
        public Rabbit(int count) : base(count)
        {
        }

        public override string Name
        {
            get { return "Rabbit"; }
        }

        public override double FoodGrams
        {
            get { return Count * 100.0; }
        }
    }

    class Animal_Farms<T> where T : Animal
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T this[int index]
        {
            get { return items[index]; }
        }
    }

    class Program
    {
        static int ReadCount(string text)
        {
            Console.Write(text);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.Write("Невалиден вход. Въведете неотрицателно цяло число: ");
            }
            return number;
        }

        static void Main(string[] args)
        {
            Animal_Farms<Animal> farm = new Animal_Farms<Animal>();

            int birds = ReadCount("Птици: ");
            farm.Add(new Bird(birds));

            int cows = ReadCount("Крави: ");
            farm.Add(new Cow(cows));

            int rabbits = ReadCount("Зайци: ");
            farm.Add(new Rabbit(rabbits));

            double total = 0;
            for (int i = 0; i < farm.Count; i++)
            {
                Animal animal = farm[i];
                Console.WriteLine(animal.Name + ": " + animal.FoodGrams + " g");
                total = total + animal.FoodGrams;
            }

            Console.WriteLine("Total: " + total + " g");
        }
    }
}
