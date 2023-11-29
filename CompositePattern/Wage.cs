using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Wage
{
    public decimal Amount { get; }

    public Wage(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Wage amount cannot be negative.");
        }

        Amount = amount;
    }

    public override string ToString()
    {
        return $"{Amount:C}";
    }
}

