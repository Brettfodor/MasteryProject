using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }

        public Nurse(string name, int employeeNumber, int numberOfPatients)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = 50000;
            Paid = false;
            NumberofPatients = numberOfPatients;
        }

        public void CareForPatient()
        {

        }
    }
}
