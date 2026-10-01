public class Player
{
    private string _name;
    private int _points;
    private static int _countPlayers;

    public string Name { get; private set; }
    public int Points { get; private set; }
    public static int CountPlayers { get; private set; }

    public Player(string name , int points)
    {
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be null or empty.");
        }
        else
        {
            Name = name;
            Points = points;
            _countPlayers++;
        }
    }
    public Player() : this("Unknown player", 0)
    {
        
    }
}

