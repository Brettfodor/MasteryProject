using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }


        public Doctor(string name, string employeeNumber, string specialty) : base(name, employeeNumber)
        {
            
            Salary = 90000;
            Specialty = specialty;
        }

        public void CareForPatient()
        {

        }

        public override void CheckInfo()
        {
            Console.WriteLine($"Employee {EmployeeNumber} {Name} is a {Specialty}");
        }


    }
}
