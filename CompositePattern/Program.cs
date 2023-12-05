using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating instances of Worker and Manager using the provided constructor and factory method
        var worker1 = new Worker("John", new Wage(50000.00m));
        var worker2 = new Worker("Alice", new Wage(60000.00m));
        var manager1 = new Manager("Bob", new Wage(80000.00m));
        var manager2 = new Manager("Charlie", new Wage(70000.00m));

        // Creating a list of IEmployee to store different types of employees
        var employees = new List<IEmployee> { worker1, worker2, manager1, manager2 };

        // Displaying the unsorted list of employees
        Console.WriteLine("Unsorted Employees:");
        foreach (var employee in employees)
        {
            employee.Display();
        }

        // Sorting the employees by name using the EmployeeSortingService
        var sortingService = new EmployeeSortingService();
        sortingService.SortByName(employees);

        // Displaying the employees after sorting by name
        Console.WriteLine("\nEmployees Sorted by Name:");
        foreach (var employee in employees)
        {
            employee.Display();
        }

        // Sorting the employees by wage using the EmployeeSortingService
        sortingService.SortByWage(employees);

        // Displaying the employees after sorting by wage
        Console.WriteLine("\nEmployees Sorted by Wage:");
        foreach (var employee in employees)
        {
            employee.Display();
        }
    }
}
