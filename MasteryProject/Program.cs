using System;
using System.Collections.Generic;
namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {   Employee employee = new Employee();
            Doctor Doctor = new Doctor("Don", "0001", "Gastroenterology");
            Nurse Nurse = new Nurse("Kathy", "0002", 1);
            Receptionist Receptionist = new Receptionist("Yolanda", "0003", false);
            Janitor Janitor = new Janitor("Dingus", "0004", false);
            Hospital hospital = new Hospital();
            bool usingApp = true;
            while (usingApp)
            {
                Console.WriteLine("Hello!  What would you like to do?");
                Console.WriteLine("Type '1' to print out a list of employees");
                Console.WriteLine("Type '2' to pay all employees");
                Console.WriteLine("Type '3' to choose an employee and have them perform a task");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                
                    hospital.AllCheckInfo();
                        break;


                    case "2":
                

                    foreach (Employee hospitalEmployee in hospital.employeesInHospital)
                    {
                        employee.PaySalary();
                        //Doctor.PaySalary();
                        //Nurse.PaySalary();
                        //Janitor.PaySalary();
                        //Receptionist.PaySalary();

                    }
                    Console.Clear();
                    Console.WriteLine("All Employees have been paid");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                        break;


                    case "3":
                

                    hospital.SelectEmployee(hospital);
                    Console.WriteLine($"What would you like to do with {employee.Name}?");

                        break;
                

                }


            }


            }
    }
}
