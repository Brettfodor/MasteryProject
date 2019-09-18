using System;
using Xunit;

namespace MasteryProject.Tests
{
    public class EmployeeTests
    {
        Employee employee;
        public EmployeeTests()
        {
            employee = new Employee("Don", "0005");
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
    }
}
