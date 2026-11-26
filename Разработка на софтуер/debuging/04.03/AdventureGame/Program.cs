using System;
class Player
{
    public int X;
    public int Y;
    public int Health;
    public Player()
    {
        X = 0;
        Y = 0;
        Health = 100;
    }
    public bool Move(string direction, int mapWidth, int mapHeight) // 
    {
        int newX = X; // 
        int newY = Y;
        if (direction == "up")
            newY++;
        else if (direction == "down")
            newY--;
        else if (direction == "left")
            newX--;
        else if (direction == "right")
            newX++;
        else
        {
            Console.WriteLine("Unknown direction!");
            return false; //
        }
        if (newX < 0 || newX >= mapWidth || newY < 0 || newY >= mapHeight) //
        {
            Console.WriteLine("You can't go outside the map!");
            return false; //
        }
        X = newX;
        Y = newY;
        return true;
    }
}
class AdventureGame
{
    static int mapWidth = 5;
    static int mapHeight = 5;
    static Player player = new Player();
    static Random random = new Random(); // 
    static void Main()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.WriteLine("Use commands: up, down, left, right, quit");
        string command = "";
        while (command != "quit" && player.Health > 0) // 
        {
            Console.Write($"Player position: ({player.X},{player.Y}) | Health: {player.Health}\n> ");
            command = Console.ReadLine();
            if (command == null) // 
            {
                command = "quit";
            }
            if (command == "quit") // 
            {
                break;
            }
            if (player.Move(command, mapWidth, mapHeight)) // 
            {
                int damage = random.Next(0, 20);
                player.Health -= damage;
                if (player.Health < 0) // 
                {
                    player.Health = 0;
                }
                Console.WriteLine($"You took {damage} damage!");
            }
        }
        if (player.Health <= 0)
        {
            Console.WriteLine("You have no health left!");
        }
        Console.WriteLine("Game Over!");
    }
}
