namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonTrainer
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);
                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.FirstOrDefault(t => t.Name == trainerName) == null)
                {
                    var trainer = new Trainer(trainerName, 0);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    trainers.FirstOrDefault(t => t.Name == trainerName).Pokemons.Add(pokemon);
                }
            }


            while ((input = Console.ReadLine()) != "End")
            {
                var element = string.Empty;
                switch (input)
                {
                    case "Fire":
                        element = "Fire";
                        CheckForElement(element, trainers);
                        break;
                    case "Electricity":
                        element = "Electricity";
                        CheckForElement(element, trainers);
                        break;
                    case "Water":
                        element = "Water";
                        CheckForElement(element, trainers);
                        break;
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Badgeds))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badgeds} {trainer.Pokemons.Count()}");
            }
        }

        public static void CheckForElement(string element, List<Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Where(x => x.Element == element).Any())
                {
                    trainer.Badgeds += 1;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                        if (pokemon.Health <= 0)
                        {
                            trainer.Pokemons.Remove(pokemon);
                            break;
                        }
                    }
                }
            }
        }
    }
}
