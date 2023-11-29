using System;

class Program
{
    static void Main()
    {
        var worker1 = new Worker("John", new Wage(50000.00m));
        var worker2 = new Worker("Alice", new Wage(60000.00m));
        var manager1 = new Manager("Bob", new Wage(80000.00m));
        var manager2 = new Manager("Charlie", new Wage(70000.00m));

        var employees = new List<Employee> { worker1, worker2, manager1, manager2 };

        // Display unsorted employees
        Console.WriteLine("Unsorted Employees:");
        foreach (var employee in employees)
        {
            employee.Display();
        }

        // Sort employees by name
        var sortingService = new EmployeeSortingService();
        sortingService.SortByName(employees);

        // Display employees after sorting by name
        Console.WriteLine("\nEmployees Sorted by Name:");
        foreach (var employee in employees)
        {
            employee.Display();
        }

        // Sort employees by wage
        sortingService.SortByWage(employees);

        // Display employees after sorting by wage
        Console.WriteLine("\nEmployees Sorted by Wage:");
        foreach (var employee in employees)
        {
            employee.Display();
        }
    }
}
