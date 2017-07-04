namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();

                var model = carInfo[0];

                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var engine = new Engine(engineSpeed, enginePower);

                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var cargo = new Cargo(cargoWeight, cargoType);
                
                var tire1Pressure = double.Parse(carInfo[5]);
                var tire1Age = int.Parse(carInfo[6]);
                var tire2Pressure = double.Parse(carInfo[7]);
                var tire2Age = int.Parse(carInfo[8]);
                var tire3Pressure = double.Parse(carInfo[9]);
                var tire3Age = int.Parse(carInfo[10]);
                var tire4Pressure = double.Parse(carInfo[11]);
                var tire4Age = int.Parse(carInfo[12]);
                var tires = new Tires(tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            var cargoTypoNeeded = Console.ReadLine();
            if (cargoTypoNeeded == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == "fragile")
                    .Where(x => x.Tires.LessThanOnePressure())
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
            else if (cargoTypoNeeded == "flamable")
            {
                cars.Where(x => x.Cargo.CargoType == "flamable")
                    .Where(x => x.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
