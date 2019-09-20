using System;
using System.Collections.Generic;
namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {   Employee employee = new Employee("Don", "0005");
            Doctor Doctor = new Doctor("Don", "0001", "Gastroenterology");
            Nurse Nurse = new Nurse("Kathy", "0002", 1);
            Receptionist Receptionist = new Receptionist("Yolanda", "0003", false);
            Janitor Janitor = new Janitor("Dingus", "0004", false);
            Hospital hospital = new Hospital();
            Patient patient = new Patient();
           
            bool usingApp = true;
            while (usingApp)
            {
                employee = new Employee();
                Console.WriteLine("Hello!  What would you like to do?");
                Console.WriteLine("Type '1' to print out a list of employees");
                Console.WriteLine("Type '2' to pay all employees");
                Console.WriteLine("Type '3' to have a Doctor or Nurse draw blood or care for a patient");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                    hospital.AllCheckInfo();
                        break;


                    case "2":
                        hospital.AllPaySalary();
                        break;


                    case "3":
                        Console.Clear();
                        Console.WriteLine("Type '1' to assign a Doctor to draw blood from a patient");
                        Console.WriteLine("Type '2' to assign a Nurse to draw blood from a patient");
                        Console.WriteLine("type '3' to assign a Doctor to care for a patient");
                        Console.WriteLine("Type '4' to assign a Nurse to care for a patient");

                        int userChoice =Convert.ToInt32(Console.ReadLine());
                        
                        if (userChoice == 1)
                        {
                            Doctor.CheckPatientBloodLevel(patient);
                            Console.WriteLine($" A doctor drew blood and the patient's blood level is now {patient.BloodLevel}");
                            Console.WriteLine("Press 'Enter' to continue");
                            Console.ReadLine();
                            Console.Clear();


                        }
                        else if (userChoice == 2)
                        {

                            Nurse.CheckPatientBloodLevel(patient);
                            Console.WriteLine($"A nurse drew blood, and The patient's blood level is now {patient.BloodLevel}");
                            Console.WriteLine("Press 'Enter' to continue");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else if (userChoice == 3)
                        {
                            Doctor.CareForPatient(patient);
                            Console.WriteLine($"A doctor assisted the patient. The patient's health level is now {patient.HealthLevel}");
                            Console.WriteLine("Press 'Enter' to continue");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (userChoice == 4)
                        {
                            Nurse.CareForPatient(patient);
                            Console.WriteLine($"A nurse assisted the patient, and the patient's health level is now {patient.HealthLevel}");
                            Console.WriteLine("Press 'Enter' to continue");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        


                        break;
                

                }

                Console.Clear();
            }


            }
    }
}
