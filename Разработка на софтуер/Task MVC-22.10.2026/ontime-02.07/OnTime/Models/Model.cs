namespace OnTime.Models;

public class Model
{
    public int ExamHour { get; private set; }
    public int ExamMinute { get; private set; }
    public int ArriveHour { get; private set; }
    public int ArriveMinute { get; private set; }
    public string Details { get; private set; }   // втори ред (пълни се в Calculate)

    public Model(int examHour, int examMinute, int arriveHour, int arriveMinute)
    {
        ExamHour = examHour;
        ExamMinute = examMinute;
        ArriveHour = arriveHour;
        ArriveMinute = arriveMinute;
        Details = "";
    }

    public Model() : this(0, 0, 0, 0)
    {
    }

    public bool IsValid()
    {
        if (ExamHour >= 0 && ExamHour <= 23 &&
            ExamMinute >= 0 && ExamMinute <= 59 &&
            ArriveHour >= 0 && ArriveHour <= 23 &&
            ArriveMinute >= 0 && ArriveMinute <= 59)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Calculate()
    {
        // Всичко в минути от началото на деня
        int exam = ExamHour * 60 + ExamMinute;
        int arrive = ArriveHour * 60 + ArriveMinute;
        int difference = exam - arrive;   

        string status;
        if (difference < 0)
        {
            status = "Late";
        }
        else if (difference <= 30)
        {
            status = "On time";
        }
        else
        {
            status = "Early";
        }

        string word = "before";
        if (difference < 0)
        {
            word = "after";
            difference = -difference;
        }

        int hours = difference / 60;
        int minutes = difference % 60;

        if (difference == 0)
        {
            Details = "";
        }
        else if (hours == 0)
        {
            Details = minutes + " minutes " + word + " the start";
        }
        else
        {
            string mm = minutes.ToString();
            if (minutes < 10)
            {
                mm = "0" + minutes;
            }
            Details = hours + ":" + mm + " hours " + word + " the start";
        }

        return status;
    }
}
