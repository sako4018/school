using System;
class StudentGrades
{
    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int count = int.Parse(Console.ReadLine());
        double[] grades = new double[count];
        double total = 0;
        Console.WriteLine("Enter grades (0 - 6):");
        for (int i = 0; i <= count; i++)
        {
            Console.Write($"Grade {i + 1}: ");
            grades[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < count; i++)
        {
            total = total + grades[0];
        }
        double average = total / count;
        Console.WriteLine($"Average grade: {average}");
    }
}
