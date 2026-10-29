namespace OnTime.Views;

public class View
{
    public int ExamHour { get; set; }
    public int ExamMinute { get; set; }
    public int ArriveHour { get; set; }
    public int ArriveMinute { get; set; }

    public void GetValues()
    {
        Console.Write("Exam hour: ");
        ExamHour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Exam minute: ");
        ExamMinute = Convert.ToInt32(Console.ReadLine());
        Console.Write("Arrive hour: ");
        ArriveHour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Arrive minute: ");
        ArriveMinute = Convert.ToInt32(Console.ReadLine());
    }

    public void ShowVal(string status, string details)
    {
        Console.WriteLine(status);
        if (details != "")
        {
            Console.WriteLine(details);
        }
    }

    public void ShowError()
    {
        Console.WriteLine("Invalid input!");
    }
}
