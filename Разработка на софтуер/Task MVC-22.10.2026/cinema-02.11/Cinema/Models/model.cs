class Model
{
    private int _row;
    private int _col;
    private string _type;

    public int Row{get;private set;}
    public int Col{get;private set;}
    public string Type{get;private set;}

    public Model(int row, int col, string type)
    {
        Row = row;
        Col = col;
        Type = type;
    }
    public Model() : this(0,0," ")
    {
        
    }

    public bool IsValid()
    {
        if ((Type == "Premiere") || 
        (Type == "Normal") ||
        (Type == "Discount"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double Prices()
    {
        if(Type == "Premiere")
        {
            return 12;
        }
        else if (Type == "Normal")
        {
            return 7.5;
        }
        else if(Type == "Discount")
        {
            return 5;
        }
        else
        {
            return 0;
        }
    }
    public double Calculate()
    {
        double income = Row * Col * Prices();
        return income;
    }
}