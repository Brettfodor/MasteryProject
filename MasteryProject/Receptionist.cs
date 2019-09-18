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
                Console.WriteLine($"Employee {EmployeeNumber}, {Name} is not on the phone");
            }
            else
            {
                Console.WriteLine($"Employee {EmployeeNumber}, {Name} is on the phone");
            }
        }
    }
}
