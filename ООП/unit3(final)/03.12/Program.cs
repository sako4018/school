using System;

namespace Task_03_12
{
    interface IAnimal
    {
        string tail{ get; set; }
        string beak { get; set; }
        void show();
    }
    interface Imammal
    {
        string baby_mammal { get; set; }
        void show();
    }
    class Snake : IAnimal
    {
        public string tail{get; set; }
        public string beak{get; set; }

        public Snake()
        {
            tail = "tail";
            beak = "";
        }
        public void show()
        {
            System.Console.WriteLine($"Snake has got {tail}");
        }
    }
    class Lion : IAnimal, IMammal
    {
        public string tail {get; set; }
        public string beak {get; set; }
        public string baby_mammal{get; set; }
        public Lion()
        {
            tail = "tail";
            beak = "";
            baby_mammal = "baby mammal";
        }
        public void show()
        {
            System.Console.WriteLine($"Lion has got {tail} and {baby_mammal}");
        }
    }
    class Bird : IAnimal
    {
        public string tail
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
