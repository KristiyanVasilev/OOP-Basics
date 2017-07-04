namespace DefiningClassesExc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class CompanyRoster
    {
        public static void Main()
        {
            int age;
            var number = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            for (int i = 0; i < number; i++)
            {
                var employeeInfo = Console.ReadLine().Split();
                var employee = new Employee(
                               employeeInfo[0],
                               decimal.Parse(employeeInfo[1]),
                               employeeInfo[2],
                               employeeInfo[3]);

                if (employeeInfo.Length > 4)
                {
                    if (int.TryParse(employeeInfo[4], out age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = employeeInfo[4];
                    }
                }
                if (employeeInfo.Length > 5)
                {
                    employee.Age = int.Parse(employeeInfo[5]);
                }
                employees.Add(employee);
            }

            var departaments = employees.GroupBy(em => em.Department)
                .Select(gr => new
                {
                    Name = gr.Key,
                    AverageSalary = gr.Average(em => em.Salary),
                    Employees = gr
                })
                .OrderByDescending(gr => gr.AverageSalary)
                .FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {departaments.Name}");
            foreach (var employee in departaments.Employees.OrderByDescending(em => em.Salary))
            {
                Console.WriteLine(employee.PrintEmployeeInfo());
            }
        }
    }
}
