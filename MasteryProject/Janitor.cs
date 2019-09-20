using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor(string name, string employeeNumber, bool isSweeping) : base(name, employeeNumber)
        {
            
            Salary = 40000;
            IsSweeping = false;
        }

        public override void CheckInfo()
        {
            if (IsSweeping == true)
            {
                Console.WriteLine($" Employee Name: {Name} Employee ID: {EmployeeNumber} Employee Salary: {Salary} Employee Status: Sweeping");
            }
            else
            {
                Console.WriteLine($" Employee Name: {Name} Employee ID: {EmployeeNumber} Employee Salary: {Salary} Employee Status: not Sweeping");
            }
        }
        public override void PaySalary()
        {
            if (!Paid)
            {
                Console.WriteLine($"You Have Paid {Name} {Salary}.");
                Paid = true;
                
            }
            else
            { Console.WriteLine($"{Name} has already been paid.");
                
            }
        }


    }
}
