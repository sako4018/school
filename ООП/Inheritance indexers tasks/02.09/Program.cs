using System;
using System.Collections.Generic;

namespace Task_02_09
{
    class ParkingEntry
    {
        public int VehicleNumber { get; }
        public int Minutes { get; }
        public decimal Price { get; }

        public ParkingEntry(int vehicleNumber, int minutes, decimal price)
        {
            VehicleNumber = vehicleNumber;
            Minutes = minutes;
            Price = price;
        }
    }

    class ParkingMachine
    {
        List<ParkingEntry> entries = new List<ParkingEntry>();
        readonly decimal hourlyRate;

        public ParkingMachine(decimal hourlyRate)
        {
            if (hourlyRate <= 0)
            {
                throw new ArgumentException("Hourly rate must be positive.");
            }
            this.hourlyRate = hourlyRate;
        }

        public int Count
        {
            get { return entries.Count; }
        }

        public ParkingEntry this[int index]
        {
            get
            {
                if (index < 0 || index >= entries.Count)
                {
                    throw new ArgumentOutOfRangeException("index", "Index is out of range.");
                }
                return entries[index];
            }
        }

        public void AddEntry(int vehicleNumber, int minutes)
        {
            if (vehicleNumber < 1000 || vehicleNumber > 4999)
            {
                throw new ArgumentException("Vehicle number must be from 1000 to 4999.");
            }
            if (minutes < 30 || minutes > 180)
            {
                throw new ArgumentException("Minutes must be from 30 to 180.");
            }
            decimal price = minutes / 60m * hourlyRate;
            entries.Add(new ParkingEntry(vehicleNumber, minutes, price));
        }
    }

    class ParkingMachineForCar : ParkingMachine
    {
        public ParkingMachineForCar() : base(3.00m)
        {
        }
    }

    class ParkingMachineForBus : ParkingMachine
    {
        public ParkingMachineForBus() : base(6.00m)
        {
        }
    }

    class Program
    {
        static Random random = new Random();

        static void FillMachine(ParkingMachine machine)
        {
            for (int i = 0; i < 3; i++)
            {
                int vehicleNumber = random.Next(1000, 5000);
                int minutes = random.Next(30, 181);
                machine.AddEntry(vehicleNumber, minutes);
            }
        }

        static void PrintMachine(ParkingMachine machine)
        {
            for (int i = 0; i < machine.Count; i++)
            {
                ParkingEntry entry = machine[i];
                Console.WriteLine($"Номер: {entry.VehicleNumber}, минути: {entry.Minutes}, цена: {entry.Price:F2} лв.");
            }
        }

        static void TryAdd(ParkingMachine machine, int vehicleNumber, int minutes)
        {
            try
            {
                machine.AddEntry(vehicleNumber, minutes);
                Console.WriteLine($"{minutes} минути: приет");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{minutes} минути: отхвърлен ({e.Message})");
            }
        }

        static void Main(string[] args)
        {
            ParkingMachineForCar carMachine = new ParkingMachineForCar();
            ParkingMachineForBus busMachine = new ParkingMachineForBus();

            FillMachine(carMachine);
            FillMachine(busMachine);

            Console.WriteLine("Автомобили (3.00 лв./час):");
            PrintMachine(carMachine);
            Console.WriteLine();
            Console.WriteLine("Автобуси (6.00 лв./час):");
            PrintMachine(busMachine);
            Console.WriteLine();

            ParkingMachineForCar testCar = new ParkingMachineForCar();
            ParkingMachineForBus testBus = new ParkingMachineForBus();
            int[] minutesList = { 30, 60, 180 };
            Console.WriteLine("Цени по минути:");
            for (int i = 0; i < minutesList.Length; i++)
            {
                testCar.AddEntry(1000 + i, minutesList[i]);
                testBus.AddEntry(1000 + i, minutesList[i]);
                Console.WriteLine($"{minutesList[i]} мин: автомобил {testCar[i].Price:F2} лв., автобус {testBus[i].Price:F2} лв.");
            }
            Console.WriteLine();

            Console.WriteLine("Двойно четене на запис 0:");
            ParkingEntry first = carMachine[0];
            ParkingEntry second = carMachine[0];
            Console.WriteLine($"{first.VehicleNumber}, {first.Minutes}, {first.Price:F2}");
            Console.WriteLine($"{second.VehicleNumber}, {second.Minutes}, {second.Price:F2}");
            Console.WriteLine($"Count: {carMachine.Count}");
            Console.WriteLine();

            Console.WriteLine("Проверка на границите:");
            TryAdd(carMachine, 2000, 29);
            TryAdd(carMachine, 2000, 181);
            Console.WriteLine($"Count: {carMachine.Count}");
            try
            {
                ParkingEntry wrong = carMachine[carMachine.Count];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Индекс Count: отхвърлен");
            }
        }
    }
}
