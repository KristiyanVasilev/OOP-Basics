namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FamilyTree
    {
        public static void Main()
        {
            var person = Console.ReadLine();
            var people = new List<Person>();
            string pairs;
            while ((pairs = Console.ReadLine()) != "End")
            {
                if (pairs.Contains("-"))
                {
                    var tokens = pairs.Split('-').Select(x => x.Trim()).ToArray();
                    var parentInfo = tokens[0];
                    var childInfo = tokens[1];

                    var parent = new Person();
                    if (parentInfo.Contains("/"))
                    {
                        parent.Date = parentInfo;
                    }
                    else
                    {
                        parent.Name = parentInfo;
                    }

                    var child = new Person();
                    if (childInfo.Contains("/"))
                    {
                        child.Date = childInfo;
                    }
                    else
                    {
                        child.Name = childInfo;
                    }
                    AddParentIfMissing(people, parent);
                    if (parent.Name != null)
                    {
                        people.FirstOrDefault(x => x.Name == parent.Name).AddChild(child);
                    }
                    else
                    {
                        people.FirstOrDefault(x => x.Date == parent.Date).AddChild(child);
                    }
                }
                else
                {
                    var added = false;
                    var tokens = pairs.Split();
                    var name = tokens[0] + " " + tokens[1];
                    var date = tokens[2];

                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i].Name == name)
                        {
                            people[i].Date = date;
                            added = true;

                        }
                        if (people[i].Date == date)
                        {
                            people[i].Name = name;
                            added = true;
                        }

                        people[i].AddChildrenInfo(name, date);
                    }
                    if (!added)
                    {
                        people.Add(new Person(name, date));
                    }
                }
            }
            PrintParentsAndChildren(people, person);
        }

        private static void PrintParentsAndChildren(List<Person> people, string person)
        {
            Person printPerson;
            if (person.Contains("/"))
            {
                printPerson = people.FirstOrDefault(p => p.Date == person);
            }
            else
            {
                printPerson = people.FirstOrDefault(p => p.Name == person);
            }
            var result = new StringBuilder();
            result.AppendLine($"{printPerson.Name} {printPerson.Date}");
            result.AppendLine("Parents:");
            foreach (var parent in people.Where(p => p.FindChildName(printPerson.Name) != null))
            {
                result.AppendLine($"{parent.Name} {parent.Date}");
            }
            result.AppendLine("Children:");
            foreach (var child in people.FirstOrDefault(p => p.Name == printPerson.Name).Children)
            {
                result.AppendLine($"{child.Name} {child.Date}");
            }
            Console.WriteLine(result);
        }

        private static void AddParentIfMissing(List<Person> people, Person parent)
        {
            if (parent.Name != null && people.Any(p => p.Name == parent.Name))
            {
                return;
            }
            if (parent.Date != null && people.Any(p => p.Date == parent.Date))
            {
                return;
            }
            people.Add(parent);
        }
    }
}
