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
        public Employee()
        {

        }

         public virtual void PaySalary()
        {
            
        }
        public virtual void CheckInfo()
        {
            
        }
        

    
        
    }
}
