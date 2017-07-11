using System;
using System.Text;

public class Worker : Human
{
    private decimal salary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal salary, decimal workHoursPerDay) : base(firstName, lastName)
    {
        this.WorkHoursPerDay = workHoursPerDay;
        this.Salary = salary;
    }

    public decimal WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }

        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    public decimal Salary
    {
        get { return this.salary; }

        set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.salary = value;
        }
    }

    private decimal CalculateSalaryPerHour()
    {
        return this.Salary / (this.WorkHoursPerDay * 5m);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {base.FirstName}");
        sb.AppendLine($"Last Name: {base.LastName}");
        sb.AppendLine($"Week Salary: {this.Salary:f2}");
        sb.AppendLine($"Hours per day: {this.workHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():f2}");
        return sb.ToString();
    }
}

