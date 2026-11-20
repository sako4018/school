using System;
using System.Collections.Generic;
class Player
{
    public string Name;
    public int Score;
    public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }
}
class Scoreboard
{
    private List<Player> players = new List<Player>();
    public void AddPlayer(string name, int score)
    {
        if (score < 0)
            Console.WriteLine("Score cannot be negative");
        else
            players.Add(new Player(name, score));
    }
    public void DisplayPlayers()
    {
        Console.WriteLine("Players:");
        for (int i = 0; i <= players.Count; i++)
        {
            Console.WriteLine(players[i].Name + " - " + players[i].Score);
        }
    }
    public void FindTopPlayer()
    {
        Player top = players[0];
        for (int i = 0; i <= players.Count; i++)
        {
            if (players[i].Score > top.Score)
                top = players[i];
        }
        Console.WriteLine($"Top player: {top.Name} with {top.Score} points");
    }
    public void SearchPlayer(string name)
    {
        bool found = false;
        foreach (var p in players)
        {
            if (p.Name.ToLower() == name.ToUpper())
            {
                Console.WriteLine($"{p.Name} - {p.Score}");
                found = true;
            }
        }
    }
    public double CalculateAverageScore()
    {
        double total = 0;
        for (int i = 0; i < players.Count; i++)
        {
            total += players[i].Score;
        }
        return total / players.Count;
    }
}
class Program
{
    static void Main()
    {
        Scoreboard board = new Scoreboard();
        string command = "";
        Console.WriteLine("Commands: add, show, top, search, average, quit");
        while (command != "quit")
        {
            Console.Write("> ");
            command = Console.ReadLine();
            if (command == "add")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter score: ");
                int score = int.Parse(Console.ReadLine());
                board.AddPlayer(name, score);
            }
            else if (command == "show")
                board.DisplayPlayers();
            else if (command == "top")
                board.FindTopPlayer();
            else if (command == "search")
            {
                Console.Write("Enter player name: ");
                string name = Console.ReadLine();
                board.SearchPlayer(name);
            }
            else if (command == "average")
                Console.WriteLine($"Average score: {board.CalculateAverageScore()}");
            else
                Console.WriteLine("Unknown command!");
        }
        Console.WriteLine("Goodbye!");
    }
}
