using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Employee
{
    public string _name;
    public Wage WorkerWage { get; } // New property

    // Private constructor to enforce the use of the factory method
    public Worker(string name, Wage wage)
    {
        _name = name;
        WorkerWage = wage;
    }

    public void Display()
    {
        Console.WriteLine($"Worker: {_name}, Wage: {WorkerWage}");
    }

    // Factory method to create Worker instances
    public static Worker CreateWorker(string name, decimal wageAmount)
    {
        return new Worker(name, new Wage(wageAmount));
    }
    public string GetName()
    {
        return _name;
    }

    public decimal GetWage()
    {
        return WorkerWage.Amount;
    }
}