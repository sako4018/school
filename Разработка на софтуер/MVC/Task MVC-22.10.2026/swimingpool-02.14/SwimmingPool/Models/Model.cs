using System.Security.Cryptography;

class Model
{
    private int _volume;
    private int _p1;
    private int _p2;
    private double _hours;

    public int Volume{get;private set;}
    public int P1{get; private set;}
    public int P2{get; private set;}
    public double Hours{get; private set;}

    public Model(int volume, int p1, int p2, double hours)
    {
        Volume = volume;
        P1 = p1;
        P2 = p2;
        Hours = hours;
    }
    public Model():this(0,0,0,0)
    {
        
    }
    public bool IsValid()
    {
        if((Volume >=1 && Volume <= 10000) && 
        (P1 >= 1 && P1 <= 5000) && 
        (P2 >= 1 && P2 <= 5000) &&
        (Hours >= 1 && Hours <= 24.0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Calculate()
    {
        double fullnow = (P1+P2) * Hours;
        if (fullnow <= Volume)
        {
            double percentFullnes = (fullnow / Volume) * 100;
            double p1Percent = (P1/fullnow) * 100;
            double p2Percent = (P2/fullnow) * 100;
            
        }
    }


}