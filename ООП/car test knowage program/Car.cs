public class Car
{
    private int _year;
    private string _model;
    private static int _count; 

    public int Year{get;private set;}
    public string Model{get;private set;}
    public static int Count{get;private set;}

    //
    public Car(int year, string model)
    {
        if(year < 1800 || year > DateTime.Now.Year)
        {
            throw new ArgumentException("Year must be greater than 1800 && less than the current year.");
        }
        else
        {
            Year = year;
            Model = model;
            Count++;
        }
    }
    public Car() :this(DateTime.Now.Year, "Unknown model")
    {
        
    }
    public int YearsOld()
    {
        return DateTime.Now.Year - Year;
    }
}