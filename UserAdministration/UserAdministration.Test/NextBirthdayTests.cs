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
    class NextBirthdayTests
    {
        [SetUp]
        public void Setup()
        {
            AddEmployee newEmployee = new AddEmployee();
            newEmployee.Employee.Firstname = "Name";
            newEmployee.Employee.Lastname = "B";
            newEmployee.Employee.SocialSecurityNumber = "1234";
            newEmployee.Employee.Birthdate = new DateTime(1999, 11, 10);
            newEmployee.Employee.IsActive = true;
            newEmployee.Employee.VacDays = 25;
            newEmployee.HandleValidSubmit();
        }
        [Test]
        public void BirthdayTest1()
        {
            //arrange
            
            //act
            NextBirthday nextBirthday = new NextBirthday();
            var actual = nextBirthday.NameOfNextBirthday();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreEqual("Name B with a Birthday on 10.11.2021", actual);
        }
        [Test]
        public void BirthdayTest2()
        {
            //arrange
            NextBirthday nextBirthday = new NextBirthday();
            nextBirthday.EmployeeList = new List<Employee>();

            Employee newEmployee = new Employee();
            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            nextBirthday.EmployeeList.Add(newEmployee);

            Employee newEmployee2 = new Employee();
            newEmployee2.Firstname = "Ay";
            newEmployee2.Lastname = "Me";
            newEmployee2.SocialSecurityNumber = "1239";
            newEmployee2.Birthdate = new DateTime(1995, 9, 29);
            newEmployee2.IsActive = true;
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;

            nextBirthday.EmployeeList.Add(newEmployee2);

            Employee newEmployee3 = new Employee();
            newEmployee3.Firstname = "Aya";
            newEmployee3.Lastname = "Met";
            newEmployee3.SocialSecurityNumber = "1239";
            newEmployee3.Birthdate = new DateTime(1995, 10, 17);
            newEmployee3.IsActive = true;
            newEmployee3.ID = "1239Ay";

            nextBirthday.EmployeeList.Add(newEmployee3);

            //act

            var actual = nextBirthday.NameOfNextBirthday();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual("Ay Me with a Birthday on 29.9.2021", actual);
        }
    }
}
