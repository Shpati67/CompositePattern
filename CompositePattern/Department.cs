using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// The Department class represents a department that can contain a list of employees
public class Department : IEmployeeSortable
{
    // Private fields
    private List<IEmployee> employees = new List<IEmployee>(); // List to store employees
    private string _name; // Name of the department

    // Properties (not used in the current implementation)
    public object Employee { get; set; }
    public object Employees { get; set; }

    // Constructor to initialize the department with a specified name
    public Department(string name)
    {
        _name = name;
    }

    // Method to add an employee to the department
    public void Add(IEmployee employee)
    {
        employees.Add(employee);
    }

    // Method to remove an employee from the department
    public void Remove(IEmployee employee)
    {
        employees.Remove(employee);
    }

    // Method to display information about the department and its employees
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

    // Implementing the IEmployeeSortable interface; for departments, you might return a default value or throw an exception
    public decimal GetWage()
    {
        // Departments may not have wages, so you can return a default value or throw an exception
        return 0.0m;
    }
}
