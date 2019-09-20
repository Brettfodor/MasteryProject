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
                Console.WriteLine($"Employee {EmployeeNumber}, {Name} is not sweeping");
            }
            else
            {
                Console.WriteLine($"Employee {EmployeeNumber}, {Name} is sweeping");
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
            { Console.WriteLine($"{Name} has already been paid."); }
        }


    }
}
