using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Manager : Employee, IEmployeeSortable
{
    private string _name;
    public Wage ManagerWage { get; private set; }

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

    // Implementing the Employee interface
    public void Display()
    {
        Console.WriteLine($"Manager: {_name}, Wage: {ManagerWage}");
    }

    public string GetDetails()
    {
        return $"Name: {_name}, Role: Manager";
    }
}
