using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor(string name, int employeeNumber, bool isSweeping)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = 40000;
            Paid = false;
            IsSweeping = false;
        }
    }
}
