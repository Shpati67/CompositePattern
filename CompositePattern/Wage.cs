using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Wage class represents the monetary amount for an employee
public class Wage
{
    // Property to get the amount of the wage
    public decimal Amount { get; }

    // Constructor to initialize the Wage object with a specified amount
    public Wage(decimal amount)
    {
        // Check if the provided amount is negative and throw an exception if it is
        if (amount < 0)
        {
            throw new ArgumentException("Wage amount cannot be negative.");
        }

        Amount = amount;
    }

    // Override of the ToString method to provide a formatted string representation of the wage
    public override string ToString()
    {
        return $"{Amount:C}"; // Formats the amount as a currency string
    }
}
