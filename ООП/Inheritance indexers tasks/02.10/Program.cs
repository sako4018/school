using System;
using System.Collections.Generic;

namespace Task_02_10
{
    class Manufacturer
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FaxNumber { get; private set; }

        public Manufacturer(string name, string country, string address, string phoneNumber, string faxNumber)
        {
            Name = name;
            Country = country;
            Address = address;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
        }
    }

    class Car
    {
        public string Model { get; private set; }
        public DateTime Date { get; private set; }
        public string Color { get; private set; }
        public Manufacturer Manufacturer { get; private set; }

        public Car(string model, string color, Manufacturer manufacturer, DateTime date)
        {
            Date = date;
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Manufacturer.Name} {Model}, {Date.Year}, {Color}";
        }
    }

    class Part
    {
        public string PartName { get; private set; }
        public decimal Price { get; private set; }
        public Car Car { get; private set; }

        public Part(string partName, decimal price, Car car)
        {
            PartName = partName;
            Price = price;
            Car = car;
        }
    }

    class EnginePart : Part
    {
        public EnginePart(string partName, decimal price, Car car) : base(partName, price, car)
        {
        }
    }

    class ChassisPart : Part
    {
        public ChassisPart(string partName, decimal price, Car car) : base(partName, price, car)
        {
        }
    }

    class BodyPart : Part
    {
        public BodyPart(string partName, decimal price, Car car) : base(partName, price, car)
        {
        }
    }

    class Program
    {
        static void PrintManufacturer(string name, List<Manufacturer> manufacturers, List<Car> cars)
        {
            bool found = false;
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (manufacturer.Name == name)
                {
                    found = true;
                    Console.WriteLine($"Производител: {manufacturer.Name}, {manufacturer.Country}, {manufacturer.Address}, тел. {manufacturer.PhoneNumber}, факс {manufacturer.FaxNumber}");
                    Console.WriteLine("Автомобили:");
                    foreach (Car car in cars)
                    {
                        if (car.Manufacturer == manufacturer)
                        {
                            Console.WriteLine($"  {car}");
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Няма намерени части");
            }
        }

        static void PrintEngineParts(List<Part> parts)
        {
            bool found = false;
            foreach (Part part in parts)
            {
                if (part is EnginePart)
                {
                    found = true;
                    Console.WriteLine($"{part.Car.Manufacturer.Name} {part.Car.Model}: {part.PartName}, {part.Price:F2} лв.");
                }
            }
            if (!found)
            {
                Console.WriteLine("Няма намерени части");
            }
        }

        static void PrintPartsByManufacturer(string name, List<Part> parts)
        {
            bool found = false;
            foreach (Part part in parts)
            {
                if (part.Car.Manufacturer.Name == name)
                {
                    found = true;
                    Console.WriteLine($"{part.PartName} ({part.Car.Model}), {part.Price:F2} лв.");
                }
            }
            if (!found)
            {
                Console.WriteLine("Няма намерени части");
            }
        }

        static void Main(string[] args)
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            List<Car> cars = new List<Car>();
            List<Part> parts = new List<Part>();

            Manufacturer renault = new Manufacturer("Renault", "France", "Paris", "0888123456", "123456");
            Manufacturer bmw = new Manufacturer("BMW", "Germany", "Munich", "0888765432", "654321");

            manufacturers.Add(renault);
            manufacturers.Add(bmw);

            Car renaultClio = new Car("Clio", "Red", renault, new DateTime(2020, 5, 15));
            Car bmwX5 = new Car("X5", "Black", bmw, new DateTime(2022, 8, 20));

            cars.Add(renaultClio);
            cars.Add(bmwX5);

            EnginePart filter = new EnginePart("Filter", 15.50m, renaultClio);
            EnginePart sparkPlugs = new EnginePart("Spark plugs", 35.00m, bmwX5);

            ChassisPart shockAbsorber = new ChassisPart("Shock absorber", 85.00m, bmwX5);
            ChassisPart belt = new ChassisPart("Belt", 22.00m, renaultClio);

            BodyPart bumper = new BodyPart("Bumper", 250.00m, bmwX5);
            BodyPart fender = new BodyPart("Fender", 120.00m, renaultClio);

            parts.Add(filter);
            parts.Add(sparkPlugs);
            parts.Add(shockAbsorber);
            parts.Add(belt);
            parts.Add(bumper);
            parts.Add(fender);

            Console.WriteLine("Търсене по Renault:");
            PrintManufacturer("Renault", manufacturers, cars);
            Console.WriteLine();

            Console.WriteLine("Части за двигател:");
            PrintEngineParts(parts);
            Console.WriteLine();

            Console.WriteLine("Части на Renault:");
            PrintPartsByManufacturer("Renault", parts);
            Console.WriteLine();

            Console.WriteLine("Части на Toyota:");
            PrintPartsByManufacturer("Toyota", parts);
            Console.WriteLine();

            Console.WriteLine("Един и същ обект Car за две части на Renault Clio:");
            Console.WriteLine(filter.Car == belt.Car);
        }
    }
}
