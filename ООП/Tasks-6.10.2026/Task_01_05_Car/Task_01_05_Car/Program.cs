using System;
using System.Runtime.CompilerServices;
using Task_01_05_Car;
namespace Task_01_05_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            System.Console.WriteLine("Enter 1 for standart");
            System.Console.WriteLine("Enter 2 for tuning");
            System.Console.WriteLine("Enter 3 for custome");
            System.Console.WriteLine("Enter 4 for exit");
            Console.Write("Enter: ");
            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1: 
                    Cars car = new Cars(model, engine, tuning, wheels);
                    cars.Add(car);
                    break;
                

            }

        }
    }
}
