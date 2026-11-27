using System;

namespace Task_03_12
{
    interface IAnimal
    {
        string tail { get; set; }
        string beak { get; set; }
        void show();
    }

    interface IMammal
    {
        string baby_mammal { get; set; }
        void show();
    }

    class Snake : IAnimal
    {
        public string tail { get; set; }
        public string beak { get; set; }

        public Snake()
        {
            tail = "tail";
            beak = "";
        }

        public void show()
        {
            Console.WriteLine("Snake has got " + tail);
        }
    }

    class Lion : IAnimal, IMammal
    {
        public string tail { get; set; }
        public string beak { get; set; }
        public string baby_mammal { get; set; }

        public Lion()
        {
            tail = "tail";
            beak = "";
            baby_mammal = "baby_mammal";
        }

        public void show()
        {
            Console.WriteLine("Lion has got " + tail + " and " + baby_mammal);
        }
    }

    class Bird : IAnimal
    {
        public string tail { get; set; }
        public string beak { get; set; }

        public Bird()
        {
            tail = "";
            beak = "beak";
        }

        public void show()
        {
            Console.WriteLine("Bird has got " + beak);
        }
    }

    class ConstrainByInterface<T> where T : IAnimal
    {
        private T animal;

        public ConstrainByInterface(T animal)
        {
            this.animal = animal;
        }

        public void Show()
        {
            animal.show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConstrainByInterface<Snake> snake = new ConstrainByInterface<Snake>(new Snake());
            ConstrainByInterface<Lion> lion = new ConstrainByInterface<Lion>(new Lion());
            ConstrainByInterface<Bird> bird = new ConstrainByInterface<Bird>(new Bird());

            snake.Show();
            lion.Show();
            bird.Show();
        }
    }
}
