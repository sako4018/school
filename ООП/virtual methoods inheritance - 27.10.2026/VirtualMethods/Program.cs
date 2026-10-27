using System;

namespace VirtualMethods
{
    class Animal
    {
        public string Name{get;private set;}
        public virtual void Speak()
        {
            System.Console.WriteLine(Name + ": ");
        }
        public Animal(string name)
        {
            Name = name;
        }
        
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            base.Speak();
            System.Console.WriteLine("Miau Miau");
        }
        public Cat():base()
        {
            
        }
        
        
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();
            System.Console.WriteLine("Bau Bau");
        }
        public Dog():base()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("reksi");
            Dog dog = new Dog();
            Cat cat = new Cat();
            
            animal.Speak();
            dog.Speak();
            cat.Speak();
        }
    }
}
