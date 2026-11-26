using System;
using System.Globalization; //
class StudentGrades
{
    static void Main()
    {
        int count = 0;
        bool validCount = false; //
        while (!validCount)
        {
            Console.WriteLine("Enter number of students:");
            string input = Console.ReadLine();
            if (input == null) //
            {
                Console.WriteLine("No input.");
                return;
            }
            if (int.TryParse(input, out count) && count > 0) //
            {
                validCount = true;
            }
            else
            {
                Console.WriteLine("Please enter a positive whole number!");
            }
        }
        double[] grades = new double[count];
        double total = 0;
        Console.WriteLine("Enter grades (0 - 6, use a dot, e.g. 5.50):");
        for (int i = 0; i < count; i++) //
        {
            bool validGrade = false;
            while (!validGrade) //
            {
                Console.Write($"Grade {i + 1}: ");
                string input = Console.ReadLine();
                if (input == null) //
                {
                    Console.WriteLine("No input.");
                    return;
                }
                double grade;
                if (double.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out grade) && grade >= 0 && grade <= 6) //
                {
                    grades[i] = grade;
                    validGrade = true;
                }
                else
                {
                    Console.WriteLine("Grade must be a number from 0 to 6!");
                }
            }
        }
        for (int i = 0; i < count; i++)
        {
            total = total + grades[i]; //
        }
        double average = total / count;
        Console.WriteLine($"Average grade: {average.ToString(CultureInfo.InvariantCulture)}"); //
    }
}
