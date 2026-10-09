using System.Dynamic;
using Microsoft.Win32.SafeHandles;

class Time
{
    private int _hour;
    private int _minutes;
    private int _seconds;

    public int Hour{get;set;}
    public int Minutes{get;set;}
    public int Seconds{get;set;}

    public Time()
    {
        
    }
    public Time(int hour, int minutes, int seconds)
    {
        if ((hour <=23 && hour >= 0) && (minutes < 60 && minutes > 0) && (seconds < 60 && seconds > 0)))
        {
            Hour = hour;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
    public void Display(Time time, int hour, int minute, int second)
    {
        if( hour < 10 )
        {
            System.Console.WriteLine($"{hour}:{minute}:{second}");

        }
    }
}