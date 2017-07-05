using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class ShoppingSpree
    {
        public static void Main()
        {
            try
            {
                var personInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var people = new List<Person>();
                for (int i = 0; i < personInput.Length; i++)
                {
                    var personInfo = personInput[i].Split('=');
                    var personName = personInfo[0];
                    var personMoney = decimal.Parse(personInfo[1]);
                    var person = new Person(personName, personMoney);
                    people.Add(person);
                }
                var products = new List<Product>();
                var productsInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productsInput.Length; i++)
                {
                    var productInfo = productsInput[i].Split('=');
                    var productName = productInfo[0];
                    var productCost = decimal.Parse(productInfo[1]);
                    var product = new Product(productName, productCost);
                    products.Add(product);
                }

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var personName = tokens[0];
                    var productName = tokens[1];
                    var currentPerson = people.FirstOrDefault(p => p.Name == personName);
                    var currentProduct = products.FirstOrDefault(p => p.Name == productName);
                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        currentPerson.Products.Add(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                        currentPerson.Money -= currentProduct.Cost;
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }
                foreach (var person in people)
                {
                    if (person.Products.Count != 0)
                    {
                        var productsToPrint = string.Join(", ", person.Products.Select(pr => pr.Name));
                        Console.WriteLine($"{person.Name} - {productsToPrint}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
