using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// The Manager class implements both the IEmployee and IEmployeeSortable interfaces
public class Manager : IEmployee, IEmployeeSortable
{
    // Private fields
    private string _name;
    public Wage ManagerWage { get; private set; } // Property to represent the manager's wage

    // Constructor that takes name and wage parameters
    public Manager(string name, Wage wage)
    {
        _name = name;
        ManagerWage = wage;
    }

    // Implementing the IEmployeeSortable interface
    public string GetName()
    {
        return _name;
    }

    public decimal GetWage()
    {
        return ManagerWage.Amount;
    }

    // Implementing the IEmployee interface
    public void Display()
    {
        Console.WriteLine($"Manager: {_name}, Wage: {ManagerWage}");
    }

    // Additional method defined by the IEmployeeSortable interface
    public string GetDetails()
    {
        return $"Name: {_name}, Role: Manager";
    }
}
