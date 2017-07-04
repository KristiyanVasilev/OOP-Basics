namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarSalesman
    {
        public static void Main()
        {
            var enginesNum = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            for (int i = 0; i < enginesNum; i++)
            {
                var engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engineModel = engineInfo[0];
                var enginePower = int.Parse(engineInfo[1]);
                var engine = new Engine(engineModel, enginePower);
                if (engineInfo.Length > 2)
                {
                    if (engineInfo.Length == 3)
                    {
                        int displacement;
                        var displValue = int.TryParse(engineInfo[2], out displacement);

                        if (displValue)
                        {
                            engine.Displacement = displacement;
                        }
                        else
                        {
                            engine.Efficiency = engineInfo[2];
                        }
                    }

                    else
                    {
                        var displacement = int.Parse(engineInfo[2]);
                        var efficienty = engineInfo.Last();

                        engine.Displacement = displacement;
                        engine.Efficiency = efficienty;
                    }
                }

                engines.Add(engine);
            }
            var carsNum = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < carsNum; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var carModel = carInfo[0];
                var carEngine = carInfo[1];
                var currentEngine = engines.Where(x => x.Model == carEngine).FirstOrDefault();
                var car = new Car(carModel, currentEngine);
                if (carInfo.Length > 2)
                {
                    if (carInfo.Length == 3)
                    {
                        int weight;
                        var weightValue = int.TryParse(carInfo[2], out weight);

                        if (weightValue)
                        {
                            car.Weight = weight;
                        }
                        else
                        {
                            car.Color = carInfo[2];
                        }
                    }
                    else
                    {
                        car.Weight = int.Parse(carInfo[2]);
                        car.Color = carInfo[3];
                    }
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }

                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
