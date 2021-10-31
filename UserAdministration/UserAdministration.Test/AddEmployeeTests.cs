using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Pages;

namespace UserAdministration.Test
{
    class AddEmployeeTests
    {
        [Test]
        public void AddEmployee()
        {
            //arrange
            AddEmployee newEmployee = new AddEmployee();

            newEmployee.Employee.Firstname = "Named";
            newEmployee.Employee.Lastname = "B";
            newEmployee.Employee.SocialSecurityNumber = "1234";
            newEmployee.Employee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.Employee.IsActive = true;
            newEmployee.Employee.VacDays = 25;


            //act
            newEmployee.HandleValidSubmit();
            var actual = newEmployee.employeeID;

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreEqual("1234Named", actual);
        }
     
        [Test]
        public void AddEmployeIDCheck()
        {
            //arrange
            AddEmployee newEmployee = new AddEmployee();

            newEmployee.Employee.Firstname = "Not";
            newEmployee.Employee.Lastname = "B";
            newEmployee.Employee.SocialSecurityNumber = "1234";
            newEmployee.Employee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.Employee.IsActive = true;
            newEmployee.Employee.VacDays = 25;


            //act
            newEmployee.HandleValidSubmit();
            var actual = newEmployee.employeeID;

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual("1234", actual);
        }
    }
}
