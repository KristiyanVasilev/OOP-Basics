namespace Minedraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var manager = new DraftManager();
            string input;
            while ((input = Console.ReadLine()) != "Shutdown")
            {
                var commands = input.Split().ToList();
                var command = commands[0];
                commands.RemoveAt(0);

                switch (command)
                {
                    case "RegisterHarvester":
                        Console.WriteLine(manager.RegisterHarvester(commands));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(manager.RegisterProvider(commands));
                        break;
                    case "Day":
                        Console.WriteLine(manager.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(manager.Mode(commands));
                        break;
                    case "Check":
                        Console.WriteLine(manager.Check(commands));
                        break;
                }
            }
            Console.WriteLine(manager.ShutDown());
        }
    }
}
