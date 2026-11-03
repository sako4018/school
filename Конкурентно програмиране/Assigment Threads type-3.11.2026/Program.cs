using System;
using System.Threading;

namespace AssigmentThreadsType
{
    class Program
    {
        static string[] names = { "Анна", "Борис", "Елена", "Георги", "Иван",  "Мария", "Огнян", "Петър", "Упи", "Ясен" };
                                

        static Thread foregroundThread = new Thread(PrintNames);

        static void PrintNames()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Име: " + names[i]);
                Thread.Sleep(500);
            }
        }

        // Background нишка – проверява дали името започва с гласна
        static void CheckVowels()
        {
            string vowels = "АЕИОУЪЮЯAEIOU";

            // изчаква малко, за да провери името, след като е изписано
            Thread.Sleep(250);

            for (int i = 0; i < names.Length; i++)
            {
                char firstLetter = char.ToUpper(names[i][0]);

                if (vowels.IndexOf(firstLetter) >= 0)
                {
                    Console.WriteLine("Името " + names[i] + " започва с гласна! Генерирано от нишката " + foregroundThread.Name);
                }

                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            foregroundThread.Name = "ForegroundNames";
            foregroundThread.IsBackground = false;

            Thread backgroundThread = new Thread(CheckVowels);
            backgroundThread.Name = "BackgroundVowels";
            backgroundThread.IsBackground = true;

            foregroundThread.Start();
            backgroundThread.Start();
        }
    }
}
