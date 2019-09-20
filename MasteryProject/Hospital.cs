using System;
using System.Collections.Generic;
using System.Text;

namespace MasteryProject
{
    class Hospital
    { 
        public List<Employee> employeesInHospital = new List<Employee>()
        {
            new Doctor("Don", "0002", "Podiatrist" ), new Nurse("Kathy", "0003", 1), new Receptionist("Yolanda", "0004", false), new Janitor("Dingus", "0005", false)
        };
        

        public void EmployeeCreation()
        {
            Console.Clear();
            // Get employee type from user
            Console.WriteLine("What type of Employee? (type 'd' doctor, 'n' for nurse, 'r' for receptionist, or 'j' for Janitor)");
            string type = Console.ReadLine();
            //Get name from user
            Console.WriteLine("What is the name of the Employee?");

            string name = Console.ReadLine();

            Console.Clear();
            // Get emp ID from user

            Console.WriteLine("What is the Employee's Employee Identification Number?");

            string employeeNumber = Console.ReadLine();

            Console.Clear();
            // Create employee

            Employee newEmployee;
            if (type == "d")
            {
                Console.WriteLine("What is the doctor's Specialty?");
                string specialty = Console.ReadLine();
                newEmployee = new Doctor(name, employeeNumber, specialty);
                employeesInHospital.Add(newEmployee);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (type == "n")
            {
                Console.WriteLine("How many patients does the Nurse Have?");
                int numberOfPatients = Convert.ToInt32(Console.ReadLine());
                newEmployee = new Nurse(name, employeeNumber, numberOfPatients);
                employeesInHospital.Add(newEmployee);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (type == "r")
            {
                Console.WriteLine("How many patients does the Nurse Have?");
                bool onThePhone = false;
                newEmployee = new Receptionist(name, employeeNumber, onThePhone);
                employeesInHospital.Add(newEmployee);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (type == "j")
            {
                Console.WriteLine("How many patients does the Nurse Have?");
                bool isSweeping = false;
                newEmployee = new Janitor(name, employeeNumber, isSweeping);
                employeesInHospital.Add(newEmployee);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }



            Console.WriteLine(name + " has been added to the Hospital Database");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

            

        }

        public void AllCheckInfo()
        {
            int i = 1;
            foreach (Employee employee in employeesInHospital)
            {

                Console.Write($"{i}."); 
                
                employee.CheckInfo();
                i++;
            }
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

        }


        public Employee SelectEmployee()
        {
            int i = 1;

            Console.WriteLine("Please choose the number of the employee you'd like to interact with");
            foreach (Employee hospitalEmployee in employeesInHospital)

            {
                Console.WriteLine($"{i}. {hospitalEmployee.Name}");
                i++;
            }
            int input  =Convert.ToInt32(Console.ReadLine()) - 1;
            Employee employee = employeesInHospital[input];


            

            return employee;

            
        }
        public void AllPaySalary()
        {
            int i = 1;
            foreach (Employee employee in employeesInHospital)
            {

                Console.Write($"{i}.");

                employee.PaySalary();
                i++;
            }
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

        }

    }
}