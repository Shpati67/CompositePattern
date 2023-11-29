using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Department : IEmployeeSortable
{
    private List<Employee> employees = new List<Employee>();
    private string _name;

    public Department(string name)
    {
        _name = name;
    }

    public void Add(Employee employee)
    {
        employees.Add(employee);
    }

    public void Remove(Employee employee)
    {
        employees.Remove(employee);
    }

    public void Display()
    {
        Console.WriteLine($"Department: {_name}");
        foreach (var employee in employees)
        {
            employee.Display();
        }
    }

    // Implementing the IEmployeeSortable interface
    public string GetName()
    {
        return _name;
    }

    public decimal GetWage()
    {
        // Departments may not have wages, so you can return a default value or throw an exception
        return 0.0m; // Default value, adjust as needed
    }
}
