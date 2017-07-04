using System;
public class Company
{
    private string name;
    private string department;
    private decimal salary;

    public Company(string name, string department, decimal salary)

    {
        this.Name = name;
        this.Depratment = department;
        this.Salary = salary;
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Depratment
    {
        get { return this.department; }
        set { this.department = value; }
    }
    public decimal Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }
}
