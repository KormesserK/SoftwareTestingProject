using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Data;
using UserAdministration.Pages;

namespace UserAdministration.Test
{
    class EmployeeCountTests
    {
        [Test]
        public void GrowthTest1()
        {
            //arrange
            EmployeeCount EmCount = new EmployeeCount();
            EmCount.EmployeeList = new List<Employee>();

            Employee newEmployee = new Employee();
            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);

            //act

            var actual = EmCount.CalculateGrowth();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreEqual("This is a growth of 166,67 percent", actual);
        }

        [Test]
        public void GrowthTest2()
        {
            //arrange
            EmployeeCount EmCount = new EmployeeCount();
            EmCount.EmployeeList = new List<Employee>();

        
            

            //act

            var actual = EmCount.CalculateGrowth();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreEqual("This is a growth of 0 percent", actual);
        }

        [Test]
        public void CountTest1()
        {
            //arrange
            EmployeeCount EmCount = new EmployeeCount();
            EmCount.EmployeeList = new List<Employee>();

            Employee newEmployee = new Employee();
            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);

            //act

            var actual = EmCount.NumberOfEmployees();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreEqual("The number of our Employees has grown from 3 to 5", actual);
        }
        [Test]
        public void CountTest2()
        {
            //arrange
            EmployeeCount EmCount = new EmployeeCount();
            EmCount.EmployeeList = new List<Employee>();

            Employee newEmployee = new Employee();
            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);
            EmCount.EmployeeList.Add(newEmployee);

            //act
            var actual = EmCount.NumberOfEmployees();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual("The number of our Employees has grown from 3 to 4", actual);
        }

    }
}
