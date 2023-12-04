using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Worker class implements the IEmployee interface
public class Worker : IEmployee
{
    // Fields
    public string _name; // Name of the worker
    public Wage WorkerWage { get; } // New property to represent the worker's wage

    // Private constructor to enforce the use of the factory method
    public Worker(string name, Wage wage)
    {
        _name = name;
        WorkerWage = wage;
    }

    // Display method to print worker details
    public void Display()
    {
        Console.WriteLine($"Worker: {_name}, Wage: {WorkerWage}");
    }

    // Factory method to create Worker instances with a specified name and wage amount
    public static Worker CreateWorker(string name, decimal wageAmount)
    {
        return new Worker(name, new Wage(wageAmount));
    }

    // Implementation of the GetName method from the IEmployee interface
    public string GetName()
    {
        return _name;
    }

    // Implementation of the GetWage method from the IEmployee interface
    public decimal GetWage()
    {
        return WorkerWage.Amount;
    }
}
