using System;

namespace Task_02_10
{
    class Program
    {
        class Manufacturer
        {
            public string Name {get; private set;}
            public string Country {get; private set;}
            public string Address {get; private set;}
            public long PhoneNumber {get; private set;}
            public long FaxNumber {get; private set;}
        }
        class Car
        {
            public string Model {get; private set;}
            public DateTime Date {get; private set;}
            public string Color {get; private set;}
            public Manufacturer Manufacturer {get; private set;}
        }
        class Part
        {
            public string PartName {get; private set;}
            public decimal Price {get; private set;}
            public string Type {get; private set;}
        }
        class EnginePart : Part
        {
            
        }
        class ChassisPart : Part
        {

        }
        class BodyPart : Part
        {
            
        }
        static void Main(string[] args)
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            List<Car> cars = new List<Car>();
            List<Part> parts = new List<Part>();

        }
    }
}
