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
        
    }
}
