using System;

namespace Animals
{
    class Animal
    {
        public void Eat()
        {
            System.Console.WriteLine("eating...");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine("barking...");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            System.Console.WriteLine("meowing...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
