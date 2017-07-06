namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamGenerator
    {
        public static void Main()
        {
            var teams = new List<Team>();
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                try
                {
                    var tokens = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    switch (tokens[0])
                    {
                        case "Team":
                            teams.Add(new Team(tokens[1]));
                            break;
                        case "Add":
                            if (!teams.Any(t => t.Name == tokens[1]))
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }
                            else
                            {
                                var currentTeam = teams.FirstOrDefault(t => t.Name == tokens[1]);
                                var player = new Player(tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]));
                                currentTeam.AddPlayer(player);
                            }
                            break;
                        case "Remove":
                            var teamForRemove = teams.FirstOrDefault(t => t.Name == tokens[1]);
                            teamForRemove.RemovePlayer(tokens[2]);
                            break;
                        case "Rating":
                            if (!teams.Any(t => t.Name == tokens[1]))
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }
                            else
                            {
                                var printTeam = teams.FirstOrDefault(t => t.Name == tokens[1]);
                                Console.WriteLine($"{printTeam.Name} - {printTeam.GetRating():f0}");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
