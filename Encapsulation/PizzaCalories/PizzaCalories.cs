using System;

namespace PizzaCalories
{
    public class PizzaCalories
    {
        public static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                try
                {
                    var tokens = line.Split();
                    switch (tokens[0])
                    {
                        case "Dough":
                            var dought = new Dought(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dought.GetCalories():f2}");
                            break;
                        case "Topping":
                            var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetCalories():f2}");
                            break;
                        case "Pizza":
                            MakePizza(tokens);
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }

        private static void MakePizza(string[] tokens)
        {
            var numberOftoppings = int.Parse(tokens[2]);
            var pizza = new Pizza(tokens[1], numberOftoppings);
            var doughInfo = Console.ReadLine().Split();
            var dought = new Dought(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
            pizza.Dought = dought;

            for (int i = 0; i < int.Parse(tokens[2]); i++)
            {
                var toppingInfo = Console.ReadLine().Split();
                var topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                pizza.AddTopping(topping);
            }
            Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
        }
    }
}
