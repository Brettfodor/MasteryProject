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
            Patient patient = new Patient();
            patient.HealthLevel += 5;
        }

        public void CheckPatientBloodLevel()
        {
            Patient patient = new Patient();
            patient.HealthLevel += 5;
        }

        public override void CheckInfo()
        {
            Console.WriteLine($"Employee {EmployeeNumber} {Name} has {NumberofPatients} patients");
        }

        public override void PaySalary()
        {
            if (!Paid)
            {
                Console.WriteLine($"You Have Paid {Name} {Salary}.");
                Paid = true;
            }
            else
            { Console.WriteLine($"{Name} has already been paid."); }
        }


    }
}
