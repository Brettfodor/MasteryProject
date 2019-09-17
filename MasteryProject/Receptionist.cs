using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(string name, int employeeNumber, bool onPhone)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = 45000;
            Paid = false;
            OnPhone = false;
        }
    }
}
