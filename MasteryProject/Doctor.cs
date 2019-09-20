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
            Patient patient = new Patient();
            patient.HealthLevel += 10;
        }
        public void CheckPatientBloodLevel()
        {
            Patient patient = new Patient();
            patient.HealthLevel += 5;
            Console.WriteLine($"The patient's health level is now {patient.HealthLevel}");
        }

        public override void CheckInfo()
        {
            Console.WriteLine($"Employee {EmployeeNumber} {Name} is a {Specialty}");
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
