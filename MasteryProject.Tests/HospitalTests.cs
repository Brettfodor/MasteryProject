using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MasteryProject.Tests
{
   public class HospitalTests
    {
        
        Patient patient;
        Employee employee;
        Doctor doctor;
        Nurse nurse;
        Receptionist receptionist;
        Janitor janitor;
        Hospital hospital;

        public HospitalTests()
        {
            employee = new Employee("Don", "0005");
            patient = new Patient();
            doctor = new Doctor("don", "0001", "podiatrist");
            nurse = new Nurse("Kathy", "0002", 1);
            receptionist = new Receptionist("yolanda", "0003", true);
            janitor = new Janitor("Dingus", "0004", true);
            hospital = new Hospital();
        }
        
    }
}
