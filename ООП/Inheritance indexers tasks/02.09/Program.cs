using System;

namespace Task_02_09
{
    class ParkingEntry
    {
        public int VehicleNumber {get;}
        public int Minutes{get;}
        public decimal Price {get;}

        public ParkingEntry(int vehicleNumber, int minutes, decimal price)
        {
            VehicleNumber = vehicleNumber;
            Minutes = minutes;
            Price = price;
        }
        public ParkingEntry():this(0, 0, 0)
        {
            
        }


    }
    class ParkingMachine
    {
        List<ParkingEntry> entries = new List<ParkingEntry>();
        readonly decimal hourlyRate = 3.00m;
        public ParkingMachine(decimal hourlyRate)
        {
            if(hourlyRate < 0)
            {
                throw new ArgumentException("Hourly rate cannot be negative.");
            }
            else
            {
                this.hourlyRate = hourlyRate;
            }

        }
        public int Count{get{return entries.Count;}}
        public void AddEntry(int vehicleNumber, int minutes)
        {
           if((vehicleNumber >= 1000 && vehicleNumber < 5000) && ((minutes >= 30 && minutes <= 180)))
            {
                decimal price = CalculatePrice(minutes);
                ParkingEntry entry = new ParkingEntry(vehicleNumber, minutes, price);
                entries.Add(entry);           
            }
           else
            {
               throw new ArgumentException("Invalid vehicle number or minutes.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
