using System;

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

        public override void CareForPatient(Patient patient)
        {
            
            patient.HealthLevel += 10;
            Console.WriteLine($"Doctor {Name} assisted the patient. The patient's health level is now {patient.HealthLevel}");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

        }
        public override void CheckPatientBloodLevel(Patient patient)
        {
            
            patient.BloodLevel -= 5;
            Console.WriteLine($" A doctor drew blood and the patient's blood level is now {patient.BloodLevel}");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public override void CheckInfo()
        {
            Console.WriteLine($" Employee Name: {Name} Employee ID: {EmployeeNumber} Employee Salary: {Salary} Employee Specialty: { Specialty}");
            
            
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
