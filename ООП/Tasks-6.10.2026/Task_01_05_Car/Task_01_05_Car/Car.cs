using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Cars
{
    public string Model{get; private set;}
    public string Type_Of_Engine{get; private set;}
    public string Tuning{get; private set;}
    public int Wheels{get;private set;}
    
    public Cars(string model, string type_of_engine, string tuning, int wheels)
    {
        Model = model;
        Type_Of_Engine = type_of_engine;
        Tuning = tuning;
        Wheels = wheels;
    }
    public Cars(string tuning)
    {
        Model = "Unknown";
        Type_Of_Engine = "Unknown";
        Tuning = tuning;
        Wheels = 4;
    }
    public Cars(int wheels)
    {
        if (wheels > 2)
        {
            Model = "Unknown";
            Type_Of_Engine = "Unknown";
            Tuning = "stock";
            Wheels = wheels;
        }
    }
    public Cars() :this("Unknown model", "Unknown type", "N/A", 4)
    {
    }
}