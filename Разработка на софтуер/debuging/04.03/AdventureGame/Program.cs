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
    public void Move(string direction)
    {
        if (direction == "up")
            Y++;
        else if (direction == "down")
            Y--;
        else if (direction == "left")
            X--;
        else if (direction == "right")
            X++;
        else
            Console.WriteLine("Unknown direction!");
    }
}
class AdventureGame
{
    static int mapWidth = 5;
    static int mapHeight = 5;
    static Player player = new Player();
    static void Main()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.WriteLine("Use commands: up, down, left, right, quit");
        string command = "";
        while (command != "quit")
        {
            Console.Write($"Player position: ({player.X},{player.Y}) | Health: {player.Health}\n> ");
            command = Console.ReadLine();
            player.Move(command);
            Random random = new Random();
            int damage = random.Next(0, 20);
            player.Health -= damage;
            Console.WriteLine($"You took {damage} damage!");
        }
        Console.WriteLine("Game Over!");
    }
}
