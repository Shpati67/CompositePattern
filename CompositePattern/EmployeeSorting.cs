using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeeSortingService
{
    public void SortByName(List<Employee> employees)
    {
        employees.Sort((e1, e2) => e1.GetName().CompareTo(e2.GetName()));
    }

    public void SortByWage(List<Employee> employees)
    {
        employees.Sort((e1, e2) => e1.GetWage().CompareTo(e2.GetWage()));
    }
}