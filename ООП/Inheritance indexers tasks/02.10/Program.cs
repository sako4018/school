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
        public EnginePart(string partname, decimal price, Car car): base(partname, price, type)
        {
            
        }
    }
    class ChassisPart : Part
    {
        public string PartChassis{get;private set;}
        public ChassisPart(string partname, decimal price, Car car): base(partname, price, type)
        {
            
        }
    }
    class BodyPart : Part
    {
        public string PartBody{get;private set;}
        public BodyPart(string partname, decimal price, Car car): base(partname, price, type)
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

        }
    }
}
