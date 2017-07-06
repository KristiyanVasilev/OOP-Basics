using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private int rating;
    private List<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.Rating = rating;
        this.players = new List<Player>();
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }
    public int Rating
    {
        get { return rating; }
        set { rating = value; }
    }
    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }
    public void RemovePlayer(string player)
    {
        if (!this.players.Any(p => p.Name == player))
        {
            throw new ArgumentException($"Player {player} is not in {this.Name} team.");
        }
        var playerToRemove = players.FirstOrDefault(p => p.Name == player);
        this.players.Remove(playerToRemove);
    }
    public double GetRating()
    {
        var rating = this.players.Select(p => p.AverageStats()).Sum();
        return rating;
    }    
}

