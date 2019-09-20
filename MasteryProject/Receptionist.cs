using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(string name, string employeeNumber, bool onPhone) : base(name, employeeNumber)
        {
            
            Salary = 45000;
            OnPhone = false;
        }

        public override void CheckInfo()
        {
            if (OnPhone == true)
            {
                Console.WriteLine($" Employee Name: {Name} Employee ID: {EmployeeNumber} Employee Salary: {Salary} Employee Status: On Phone");
            }
            else
            {
                Console.WriteLine($" Employee Name: {Name} Employee ID: {EmployeeNumber} Employee Salary: {Salary} Employee Status: Not On Phone");
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
