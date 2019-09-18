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

        
    }
}
