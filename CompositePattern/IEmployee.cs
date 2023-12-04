using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The IEmployee interface defines methods related to displaying and retrieving information about an employee
public interface IEmployee
{
    // Method to display information about the employee
    void Display();

    // Method to get the name of the employee
    string GetName();

    // Method to get the wage of the employee
    decimal GetWage();
}
