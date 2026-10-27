using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace VirtualMethodsHomework
{
    class Vehicle
    {
        private int _wheels;
        private int _seats;
        private int _speed;
        private string _model;
        private string _color;

        public int Wheels{get;private set;}
        public int Seats{get;private set;}    
        public int Speed{get;private set;}   
        public string Model{get;private set;}   
        public string Color{get;private set;}   

        public Vehicle(int wheels,int seats,int speed,string model,string color)
        {
            Wheels = wheels;
            Seats = seats;
            Speed = speed;
            Model = model;
            Color = color;
        }
        public Vehicle():this(0,1,0,"unknown","unknown")
        {
            
        }
        public bool IsValid()
        {
            if((Speed >= 0) && (Seats >= 1) && (Wheels > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void Accelerate(int increment)
        {
            if (increment < 0)
                throw new ArgumentOutOfRangeException();
            Speed += increment;
        }
    }
    class Car : Vehicle 
    {
        public Car(int wheels,int seats,int speed,string model,string color) :base( wheels,seats,speed, model, color)
        {
            
        }
        public override void Accelerate(int increment)
        {
            base.Accelerate(increment);
        }
    }
    class Motorbike : Vehicle
    {
        public Motorbike(int wheels,int seats,int speed,string model,string color) :base( wheels,seats,speed, model, color)
        {
            
        }
        public override void Accelerate(int increment)
        {
            if (increment < 0)
                throw new ArgumentOutOfRangeException();
            base.Accelerate(increment * 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
