namespace MordorsCrueltyPlan
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();
            var gandalf = new Gandalf();
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var foodStr in input)
            {
                var food = foodFactory.GetFood(foodStr);
                gandalf.Eat(food);
            }

            var totalHappinessPoints = gandalf.GetHappinessPoints();
            var currentMood = moodFactory.GetMood(totalHappinessPoints);
            Console.WriteLine(totalHappinessPoints);
            Console.WriteLine(currentMood);
        }
    }
}
