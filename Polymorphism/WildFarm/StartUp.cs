using System;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = AnimalFactory.GetAnimal(animalTokens);

                var foodTokens = Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                Food food = FoodFactory.GetFood(foodTokens);

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal);
            }
        }
    }
}
