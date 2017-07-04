using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var cars = new HashSet<Car>();
            for (int i = 0; i < number; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var carModel = carInfo[0];
                var fuelAmount = int.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);

                var car = new Car(carModel, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split();
                var neededModel = tokens[1];
                var kilometers = int.Parse(tokens[2]);
                var currentCar = cars.First(c => c.Model == neededModel);
                currentCar.CalculateDistance(kilometers);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled:f0}");
            }
        }
    }
}
