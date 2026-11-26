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
    //
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
        if (players.Count == 0) //
        {
            Console.WriteLine("No players yet.");
        }
        for (int i = 0; i < players.Count; i++) //
        {
            Console.WriteLine(players[i].Name + " - " + players[i].Score);
        }
    }
    public void FindTopPlayer()
    {
        if (players.Count == 0) //
        {
            Console.WriteLine("No players yet.");
            return;
        }
        Player top = players[0];
        for (int i = 1; i < players.Count; i++) //
        {
            if (players[i].Score > top.Score) //
                top = players[i];
        }
        Console.WriteLine($"Top player: {top.Name} with {top.Score} points");
    }
    public void SearchPlayer(string name)
    {
        bool found = false;
        foreach (var p in players)
        {
            if (p.Name.ToLower() == name.ToLower()) //
            {
                Console.WriteLine($"{p.Name} - {p.Score}");
                found = true;
            }
        }
        if (!found) //
        {
            Console.WriteLine("Player not found.");
        }
    }
    public double CalculateAverageScore()
    {
        if (players.Count == 0) //
        {
            return -1;
        }
        double total = 0;
        for (int i = 0; i < players.Count; i++)
        {
            total += players[i].Score;
        }
        return total / players.Count;
    }
    public int Count() //
    {
        return players.Count;
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
            if (command == null) //
            {
                break;
            }
            if (command == "add")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                if (name == null || name.Trim() == "") //
                {
                    Console.WriteLine("Name cannot be empty!");
                    continue;
                }
                Console.Write("Enter score: ");
                int score;
                if (!int.TryParse(Console.ReadLine(), out score)) //
                {
                    Console.WriteLine("Score must be a whole number!");
                    continue;
                }
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
                if (name == null) //
                {
                    break;
                }
                board.SearchPlayer(name);
            }
            else if (command == "average")
            {
                if (board.Count() == 0) //
                    Console.WriteLine("No players yet, no average.");
                else
                    Console.WriteLine($"Average score: {board.CalculateAverageScore()}");
            }
            else if (command == "quit")
            {
            }
            else
                Console.WriteLine("Unknown command!");
        }
        Console.WriteLine("Goodbye!");
    }
}
