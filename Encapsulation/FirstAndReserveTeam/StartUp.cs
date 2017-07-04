namespace FirstAndReserveTeam
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("The Team");            
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var player = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));

                team.AddPlayer(player);
            }
            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Second team have {team.ReserveTeam.Count} players");
        }
    }
}
