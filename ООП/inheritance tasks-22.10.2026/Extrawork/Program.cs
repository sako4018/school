using System;

namespace Extrawork
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
    class Puppy : Dog
    {
        public void Weep()
        {
            System.Console.WriteLine("weeping...");
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
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
