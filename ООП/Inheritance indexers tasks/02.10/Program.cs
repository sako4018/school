using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Task_02_10
{
    class Manufacturer
    {
        public string Name {get; private set;}
        public string Country {get; private set;}
        public string Address {get; private set;}
        public long PhoneNumber {get; private set;}
        public long FaxNumber {get; private set;}

        public Manufacturer(string name, string country, string address, long phoneNumber, long faxNumber)
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
        public string Model {get; private set;}
        public DateTime Date {get; private set;}
        public string Color {get; private set;}
        public Manufacturer Manufacturer {get; private set;}
        public Car(string model, string color, Manufacturer manifacturer, DateTime date)
        {
            Date = date;
            Manufacturer = manifacturer;
            Model = model;
            Color = color;
        }
    }
    class Part
    {
        public string PartName {get; private set;}
        public decimal Price {get; private set;}
        public Car Car{get;private set;}
    
        public Part(string partName, decimal price, Car car)
        {
            PartName = partName;
            Price = price;
            Car = car;
        }
    }
    class EnginePart : Part
    {
        public string EngineType{get;private set;}
        public EnginePart(string partname, decimal price, Car car): base(partname, price, car)
        {
            
        }
    }
    class ChassisPart : Part
    {
        public string PartChassis{get;private set;}
        public ChassisPart(string partname, decimal price, Car car): base(partname, price, car)
        {
            
        }
    }
    class BodyPart : Part
    {
        public string PartBody{get;private set;}
        public BodyPart(string partname, decimal price, Car car): base(partname, price, car)
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            List<Car> cars = new List<Car>();
            List<Part> parts = new List<Part>();


            Manufacturer renault = new Manufacturer(
                "Renault", "France", "Paris", 0888123456, 123456);

            Manufacturer bmw = new Manufacturer(
                "BMW", "Germany", "Munich", 0888765432, 654321);

            manufacturers.Add(renault);
            manufacturers.Add(bmw);



            Car renaultClio = new Car(
                "Clio", "Red", renault, new DateTime(2020, 5, 15));

            Car bmwX5 = new Car(
                "X5", "Black", bmw, new DateTime(2022, 8, 20));

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
        }
    }
}
