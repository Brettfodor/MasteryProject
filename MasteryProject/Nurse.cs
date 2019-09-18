using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    public class Nurse : Employee
    {
        public int NumberofPatients { get; set; }

        public Nurse(string name, string employeeNumber, int numberOfPatients): base(name, employeeNumber)
        {
            
            Salary = 50000;
            NumberofPatients = numberOfPatients;
        }

        public void CareForPatient()
        {

        }

        
    }
}
