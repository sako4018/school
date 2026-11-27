using System;
using System.Collections.Generic;

namespace Task_03_10
{
    interface IVehicle
    {
        void speedUp(int increment);
        void applyBrakes(int decrement);
    }

    class Bicycle : IVehicle
    {
        public int speed;
        public int gear;

        public Bicycle(int speed, int gear)
        {
            // Началната скорост е неотрицателна
            if (speed < 0)
            {
                throw new ArgumentException("Скоростта не може да е отрицателна.");
            }
            this.speed = speed;
            this.gear = gear;
        }

        public void speedUp(int increment)
        {
            if (increment < 0)
            {
                Console.WriteLine("Bicycle: отрицателна промяна " + increment + " се отхвърля");
                return;
            }
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            if (decrement < 0)
            {
                Console.WriteLine("Bicycle: отрицателна промяна " + decrement + " се отхвърля");
                return;
            }
            speed = speed - decrement;
            // Скоростта не пада под 0
            if (speed < 0)
            {
                speed = 0;
            }
        }

        public override string ToString()
        {
            return "Bicycle: speed = " + speed + ", gear = " + gear;
        }
    }

    class Car : IVehicle
    {
        public int speed;
        public int gear;

        public Car(int speed, int gear)
        {
            if (speed < 0)
            {
                throw new ArgumentException("Скоростта не може да е отрицателна.");
            }
            this.speed = speed;
            this.gear = gear;
        }

        public void speedUp(int increment)
        {
            if (increment < 0)
            {
                Console.WriteLine("Car: отрицателна промяна " + increment + " се отхвърля");
                return;
            }
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            if (decrement < 0)
            {
                Console.WriteLine("Car: отрицателна промяна " + decrement + " се отхвърля");
                return;
            }
            speed = speed - decrement;
            if (speed < 0)
            {
                speed = 0;
            }
        }

        public override string ToString()
        {
            return "Car: speed = " + speed + ", gear = " + gear;
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Generic<IVehicle> vehicles = new Generic<IVehicle>();

            vehicles.Add(new Bicycle(10, 3));
            vehicles.Add(new Car(60, 4));
            vehicles.Add(new Bicycle(5, 1));

            Console.WriteLine("В началото:");
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine(vehicles[i]);
            }
            Console.WriteLine();

            // Самопроверка през променлива от тип IVehicle: speed = 10, speedUp(5) => 15
            IVehicle first = vehicles[0];
            first.speedUp(5);
            Console.WriteLine("След speedUp(5): " + first);

            // applyBrakes(20) => 0, не под нулата
            first.applyBrakes(20);
            Console.WriteLine("След applyBrakes(20): " + first);

            // Промяна с 0 запазва състоянието
            first.speedUp(0);
            Console.WriteLine("След speedUp(0): " + first);

            // Отрицателна промяна се отхвърля
            first.speedUp(-5);
            first.applyBrakes(-5);
            Console.WriteLine("След отрицателни промени: " + first);
            Console.WriteLine();

            // Колата
            vehicles[1].speedUp(40);
            vehicles[1].applyBrakes(30);

            Console.WriteLine("Накрая:");
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine(vehicles[i]);
            }
            Console.WriteLine("Общо превозни средства: " + vehicles.Count);
        }
    }
}
