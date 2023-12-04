﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The IEmployeeSortable interface defines methods to retrieve the name and wage of an employee for sorting
public interface IEmployeeSortable
{
    // Method to get the name of the employee
    string GetName();

    // Method to get the wage of the employee
    decimal GetWage();
}
