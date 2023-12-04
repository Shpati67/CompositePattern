using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The EmployeeSortingService class provides methods to sort a list of employees by name or wage
public class EmployeeSortingService
{
    // Method to sort a list of employees by name
    public void SortByName(List<IEmployee> employees)
    {
        // Using the Sort method with a custom comparison delegate that compares employees by name
        employees.Sort((e1, e2) => e1.GetName().CompareTo(e2.GetName()));
    }

    // Method to sort a list of employees by wage
    public void SortByWage(List<IEmployee> employees)
    {
        // Using the Sort method with a custom comparison delegate that compares employees by wage
        employees.Sort((e1, e2) => e1.GetWage().CompareTo(e2.GetWage()));
    }
}