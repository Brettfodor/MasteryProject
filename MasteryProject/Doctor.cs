using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }


        public Doctor(string name, int number, string specialty)
        {
            Name = name;
            EmployeeNumber = number;
            Salary = 90000;
            Paid = false;
            Specialty = specialty;
        }
    }
}
