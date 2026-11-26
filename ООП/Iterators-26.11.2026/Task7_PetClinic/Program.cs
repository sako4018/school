using System;
using System.Collections.Generic;

namespace Task7_PetClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Pet> pets = new Dictionary<string, Pet>();
            Dictionary<string, Clinic> clinics = new Dictionary<string, Clinic>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                try
                {
                    if (command == "Create")
                    {
                        if (parts[1] == "Pet")
                        {
                            Pet pet = new Pet(parts[2], int.Parse(parts[3]), parts[4]);
                            pets[pet.Name] = pet;
                        }
                        else
                        {
                            Clinic clinic = new Clinic(parts[2], int.Parse(parts[3]));
                            clinics[clinic.Name] = clinic;
                        }
                    }
                    else if (command == "Add")
                    {
                        // Ако любимецът или клиниката не съществуват, ключът хвърля изключение
                        Pet pet = pets[parts[1]];
                        Clinic clinic = clinics[parts[2]];
                        Console.WriteLine(clinic.Add(pet));
                    }
                    else if (command == "Release")
                    {
                        Console.WriteLine(clinics[parts[1]].Release());
                    }
                    else if (command == "HasEmptyRooms")
                    {
                        Console.WriteLine(clinics[parts[1]].HasEmptyRooms());
                    }
                    else if (command == "Print")
                    {
                        Clinic clinic = clinics[parts[1]];
                        if (parts.Length == 3)
                        {
                            Console.WriteLine(clinic.PrintRoom(int.Parse(parts[2])));
                        }
                        else
                        {
                            clinic.PrintAll();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }
        }
    }
}
