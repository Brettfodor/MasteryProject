using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeNumber { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        public Employee(string name, string employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Paid = false;


        }
        public void PaySalary()
        {
            if (!Paid)
            {
                Console.WriteLine($"You Have Paid {Name} {Salary}.");
                Paid = true;
            }
            else
            { Console.WriteLine($"{Name} has already been paid."); }
        }
        public virtual void CheckInfo()
        {
            
        }
        

    
        
    }
}
