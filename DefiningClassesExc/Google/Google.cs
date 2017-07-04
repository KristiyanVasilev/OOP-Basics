namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Google
    {
        public static void Main()
        {
            var persons = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var personInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var personName = personInfo[0];
                Person person;
                if (persons.FirstOrDefault(t => t.Name == personName) == null)
                {
                    person = new Person(personName);
                }
                else
                {
                    person = persons.Where(t => t.Name == personName).FirstOrDefault();
                }


                var secondToken = personInfo[1];
                switch (secondToken)
                {
                    case "company":
                        var companyName = personInfo[2];
                        var department = personInfo[3];
                        var salary = decimal.Parse(personInfo[4]);
                        var company = new Company(companyName, department, salary);
                        person.Company = company;
                        break;
                    case "pokemon":
                        var pokemon = new Pokemon();
                        pokemon.Name = personInfo[2];
                        pokemon.Type = personInfo[3];
                        person.Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        var parent = new Parent();
                        parent.Name = personInfo[2];
                        parent.Birthday = personInfo[3];
                        person.Parents.Add(parent);
                        break;
                    case "children":
                        var child = new Children();
                        child.Name = personInfo[2];
                        child.Birthday = personInfo[3];
                        person.Children.Add(child);
                        break;
                    case "car":
                        var car = new Car(personInfo[2], int.Parse(personInfo[3]));
                        person.Car = car;
                        break;
                }
                persons.Add(person);
            }
            var wantedPerson = Console.ReadLine();
            var personToPrint = persons.Where(p => p.Name == wantedPerson).FirstOrDefault();
            Console.WriteLine(personToPrint.Name);

            if (personToPrint.Company != null)
            {
                Console.WriteLine($"Company:");
                Console.WriteLine($"{personToPrint.Company.Name} {personToPrint.Company.Depratment} {personToPrint.Company.Salary:f2}");
            }
            else
            {
                Console.WriteLine("Company:");
            }
            if (personToPrint.Car != null)
            {
                Console.WriteLine($"Car:");
                Console.WriteLine($"{personToPrint.Car.Model} {personToPrint.Car.Speed}");

            }
            else
            {
                Console.WriteLine("Car:");
            }
            if (personToPrint.Pokemons.Any())
            {
                Console.WriteLine("Pokemon:");
                foreach (var pokemon in personToPrint.Pokemons)
                {
                    Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
                }
            }
            else
            {
                Console.WriteLine("Pokemon:");
            }
            if (personToPrint.Parents.Any())
            {
                Console.WriteLine("Parents:");
                foreach (var parent in personToPrint.Parents)
                {
                    Console.WriteLine($"{parent.Name} {parent.Birthday}");
                }
            }
            else
            {
                Console.WriteLine("Parents:");
            }
            if (personToPrint.Parents.Any())
            {
                Console.WriteLine("Children:");
                foreach (var child in personToPrint.Children)
                {
                    Console.WriteLine($"{child.Name} {child.Birthday}");
                }
            }
            else
            {
                Console.WriteLine("Children:");
            }
        }
    }
}
