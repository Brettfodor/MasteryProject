using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }


        public Doctor(string name, int employeeNumber, string specialty)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = 90000;
            Paid = false;
            Specialty = specialty;
        }

        public void CareForPatient()
        {

        }
    }
}
