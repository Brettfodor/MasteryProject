using System;
using Xunit;

namespace MasteryProject.Tests
{
    public class EmployeeTests
    {   Patient patient;
        Employee employee;
        Doctor doctor;
        Nurse nurse;
        public EmployeeTests()
        {
            employee = new Employee("Don", "0005");
            patient = new Patient();
            doctor = new Doctor("don", "0001", "podiatrist");
            nurse = new Nurse("Kathy", "0002", 1);
        }
        




        [Fact]
        public void Can_Pay_Salary()
        {

            //arrange
            employee.Paid = false;
            //act
            employee.PaySalary();
            
            //assert
            Assert.True(employee.Paid);
        }
        [Fact]
        public void Doctor_Can_Care_For_Patient()
        {

            //arrange
            
            //act
            doctor.CareForPatient(patient);

            //assert
            Assert.Equal(20, patient.HealthLevel);
        }
        [Fact]
        public void Nurse_Can_Care_For_Patient()
        {

            //arrange
            
            //act
            nurse.CareForPatient(patient);

            //assert
            Assert.Equal(15, patient.HealthLevel);
        }
        [Fact]
        public void Nurse_Can_Draw_Blood()
        {

            //arrange

            //act
            nurse.CheckPatientBloodLevel(patient);

            //assert
            Assert.Equal(10, patient.BloodLevel);
        }
        [Fact]
        public void Doctor_Can_Draw_Blood()
        {

            //arrange

            //act
            doctor.CheckPatientBloodLevel(patient);

            //assert
            Assert.Equal(15, patient.BloodLevel);
        }
    }

}
