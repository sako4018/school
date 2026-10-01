namespace car_test_knowage_program;

class Program
{
    static void Main(string[] args)
    {
        /*
        Car car = new Car();
        //
        Console.WriteLine("Enter car model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Enter car year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        car = new Car(year, model);
        Console.WriteLine(car.YearsOld());
        */
        List<Player> players = new List<Player>();
        double totalPoints = 0;
        players.Add(new Player("John", 10));
        players.Add(new Player("Alice", 20));
        players.Add(new Player("Bob", 15));

        foreach(Player player in players)
        {
            Console.WriteLine($"Player: {player.Name}, Points: {player.Points}");
            totalPoints += player.Points;
        }
        if (players.Count == 0)
        {
            Console.WriteLine("No players available to calculate average points.");
        }
        else
        {
            double averagePoints = totalPoints / players.Count;
            Console.WriteLine($"Average Points: {averagePoints}");
        }
        Console.WriteLine("Enter a player's name to search: ");
        string searchName = Console.ReadLine();
        foreach(Player player in players)
        {
            if(player.Name == searchName)
            {
                Console.WriteLine($"Player found: {player.Name}, Points: {player.Points}");
                return;
            }
            else if(player.Name != searchName)
            {
                Console.WriteLine($"{searchName} not found.");
            }
        }
        

    }
}
