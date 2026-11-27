using System;
using System.Collections.Generic;

namespace Task_03_06
{
    interface IAnimal
    {
        string Type_of_animal { get; set; }
        bool HasTail { get; set; }
        bool HasBeak { get; set; }
        bool HasFur { get; set; }
        bool HasFeathers { get; set; }
        bool HasHooves { get; set; }
        int NumberOfLegs { get; set; }
    }

    interface IMammal
    {
        bool IsBabyMammal { get; set; }
    }

    interface Animal_food
    {
        bool IsHerbivore { get; set; }
        bool IsCarnivore { get; set; }
    }

    class Bird : IAnimal, Animal_food
    {
        private int numberOfLegs;

        public string Type_of_animal { get; set; }
        public bool HasTail { get; set; }
        public bool HasBeak { get; set; }
        public bool HasFur { get; set; }
        public bool HasFeathers { get; set; }
        public bool HasHooves { get; set; }
        public bool IsHerbivore { get; set; }
        public bool IsCarnivore { get; set; }

        // Броят крака е неотрицателен
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Броят крака не може да е отрицателен.");
                }
                numberOfLegs = value;
            }
        }

        public Bird(string type, bool herbivore, bool carnivore)
        {
            Type_of_animal = type;
            HasTail = true;
            HasBeak = true;
            HasFur = false;
            HasFeathers = true;
            HasHooves = false;
            NumberOfLegs = 2;
            IsHerbivore = herbivore;
            IsCarnivore = carnivore;
        }
    }

    class Cow : IAnimal, IMammal, Animal_food
    {
        private int numberOfLegs;

        public string Type_of_animal { get; set; }
        public bool HasTail { get; set; }
        public bool HasBeak { get; set; }
        public bool HasFur { get; set; }
        public bool HasFeathers { get; set; }
        public bool HasHooves { get; set; }
        public bool IsBabyMammal { get; set; }
        public bool IsHerbivore { get; set; }
        public bool IsCarnivore { get; set; }

        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Броят крака не може да е отрицателен.");
                }
                numberOfLegs = value;
            }
        }

        public Cow(string type, bool isBaby)
        {
            Type_of_animal = type;
            HasTail = true;
            HasBeak = false;
            HasFur = true;
            HasFeathers = false;
            HasHooves = true;
            NumberOfLegs = 4;
            IsBabyMammal = isBaby;
            IsHerbivore = true;
            IsCarnivore = false;
        }
    }

    // Колекция с индексатор само за четене
    class Generic_class<T>
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
            get
            {
                if (index < 0 || index >= items.Count)
                {
                    throw new IndexOutOfRangeException("Невалиден индекс: " + index);
                }
                return items[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Generic_class<IAnimal> animals = new Generic_class<IAnimal>();

            // Празна колекция
            Console.WriteLine("Празна колекция, Count = " + animals.Count);
            Console.WriteLine();

            animals.Add(new Bird("Eagle", false, true));
            animals.Add(new Bird("Sparrow", true, false));
            animals.Add(new Cow("Adult cow", false));
            animals.Add(new Cow("Calf", true));

            Console.WriteLine("Count = " + animals.Count);
            Console.WriteLine();

            for (int i = 0; i < animals.Count; i++)
            {
                IAnimal animal = animals[i];

                Console.WriteLine("Вид: " + animal.Type_of_animal);
                Console.WriteLine("  Крака: " + animal.NumberOfLegs);
                Console.WriteLine("  Опашка: " + animal.HasTail + ", клюн: " + animal.HasBeak
                    + ", козина: " + animal.HasFur + ", пера: " + animal.HasFeathers
                    + ", копита: " + animal.HasHooves);

                // Видът се разпознава по класа, не по свойствата
                if (animal is Bird)
                {
                    Console.WriteLine("  Клас: Bird");
                }
                if (animal is Cow)
                {
                    Console.WriteLine("  Клас: Cow");
                }

                // false значи възрастен бозайник
                if (animal is IMammal mammal)
                {
                    Console.WriteLine("  Бозайник, IsBabyMammal: " + mammal.IsBabyMammal);
                }
                else
                {
                    Console.WriteLine("  Не е бозайник");
                }

                if (animal is Animal_food food)
                {
                    Console.WriteLine("  Тревопасно: " + food.IsHerbivore + ", месоядно: " + food.IsCarnivore);
                }

                Console.WriteLine();
            }

            // Невалиден индекс
            try
            {
                IAnimal wrong = animals[10];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Грешка: " + e.Message);
            }
        }
    }
}
