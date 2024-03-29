﻿using System;
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

        public override void CareForPatient(Patient patient)
        {
            
            patient.HealthLevel += 5;
            

        }

        public override void CheckPatientBloodLevel(Patient patient)
        {
            
            patient.BloodLevel -= 10;
            
        }

        public override void CheckInfo()
        {
            Console.WriteLine($" Employee Name: {Name} Employee ID: {EmployeeNumber} Employee Salary: {Salary} Number of Patients: {NumberofPatients}");


        }

        public override void PaySalary()
        {
            if (!Paid)
            {
                Console.WriteLine($"You Have Paid {Name} {Salary}.");
                Paid = true;
                
            }
            else
            { Console.WriteLine($"{Name} has already been paid.");
                
            }
        }


    }
}
