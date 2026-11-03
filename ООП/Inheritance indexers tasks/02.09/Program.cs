using System;

namespace Task_02_09
{
    class ParkingEntry
    {
        static Random random = new Random();
        public int VehicleNumber {get;}
        public int Minutes{get;}
        public decimal Price {get;}

        public ParkingEntry(int vehicleNumber, int minutes, decimal price)
        {
            VehicleNumber = vehicleNumber;
            Minutes = minutes;
            Price = price;
        }
        public ParkingEntry()
        {
            VehicleNumber = random.Next(1000, 5000);
            Minutes = random.Next(30, 181);
            Price = Minutes / 60.0m * 3.00m;
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
        ParkingEntry this[int index]
        {
            get
            {
                if(index < 0 || index >= entries.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                else
                {
                    return entries[index];
                }
            }
        }
        public void AddEntry(int vehicleNumber, int minutes)
        {
            if((vehicleNumber >= 1000 && vehicleNumber < 5000) && ((minutes >= 30 && minutes <= 180)))
            {
                decimal price = minutes / 60.0m * hourlyRate; 
                ParkingEntry entry = new ParkingEntry(vehicleNumber, minutes, price);
                entries.Add(entry);
            }
            else
            {
                throw new ArgumentException("Invalid vehicle number or minutes.");
            }
        }
    }
    class ParkingMachineForCar : ParkingMachine
    {
        public ParkingMachineForCar(decimal hourlyRate) : base(hourlyRate)
        {
            hourlyRate = 3.00m;
        }
    }
    class ParkingMachineForBus : ParkingMachine
    {
        public ParkingMachineForBus(decimal hourlyRate) : base(hourlyRate)
        {
            hourlyRate = 6.00m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
