using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Data;

namespace UserAdministration.Test
{
    class EmployeeTests
    {
        [Test]
        public void ToCSVLineTest1()
        {
            //arrange
            Employee newEmployee = new Employee();

            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            //act
            var actual = newEmployee.ToCSVLine();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreEqual("1234A;A;M;1234;1999,12,1;True", actual);
        }


        [Test]
        public void ToCSVLineTest2()
        {
            //arrange
            Employee newEmployee = new Employee();

            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            //act
            var actual = newEmployee.ToCSVLine();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual("1234A;A;M;1234;1999,12,1;", actual);
        }

        [Test]
        public void WriteReadTest1()
        {
            //arrange
            int anz = Employee.ReadAllEmployees().Count;
            Employee newEmployee = new Employee();

            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            //act
            Employee.WriteEmployeeToCSV(newEmployee);
            var actual = Employee.ReadAllEmployees().Count;

            //assert

            Assert.IsNotNull(actual);
            Assert.AreEqual(anz + 1, actual);
        }

        [Test]
        public void WriteReadTest2()
        {
            //arrange
            Employee newEmployee = new Employee();

            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            //act
            Employee.WriteEmployeeToCSV(newEmployee);
            var actual = Employee.ReadAllEmployees().Last().ID;

            //assert

            Assert.IsNotNull(actual);
            Assert.AreEqual(newEmployee.ID, actual);
        }



        [Test]
        public void CreateEmployeeListFromLinesTest1()
        {
            //arrange
            var employeeList = new List<Employee>();

            Employee newEmployee = new Employee();

            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            employeeList.Add(newEmployee);

            Employee newEmployee2 = new Employee();

            newEmployee2.Firstname = "Ay";
            newEmployee2.Lastname = "Me";
            newEmployee2.SocialSecurityNumber = "1239";
            newEmployee2.Birthdate = new DateTime(1995, 10, 17);
            newEmployee2.IsActive = false;
            newEmployee2.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            employeeList.Add(newEmployee2);

            IEnumerable<string> lines = Enumerable.Empty<string>();
            lines.Append("1234A;A;M;1234;1999,12,1;True");
            lines.Append("1239Ay;Ay;Me;1239;1995,10,17;False");


            //act
            var actual = Employee.CreateEmployeeListFromLines(lines);

            //assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(lines, actual);
        }

        [Test]
        public void CreateEmployeeListFromLinesTest2()
        {
            //arrange
            var employeeList = new List<Employee>();

            Employee newEmployee = new Employee();

            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            employeeList.Add(newEmployee);

            Employee newEmployee2 = new Employee();

            newEmployee2.Firstname = "Ay";
            newEmployee2.Lastname = "Me";
            newEmployee2.SocialSecurityNumber = "1239";
            newEmployee2.Birthdate = new DateTime(1995, 10, 17);
            newEmployee2.IsActive = false;
            newEmployee2.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            employeeList.Add(newEmployee2);

            IEnumerable<string> lines = Enumerable.Empty<string>();
            lines.Append("1234A;A;M;1234;1999,12,1;True");
            lines.Append("1239Ay;Ay;Me;1239;1995,10,17;Fals");


            //act
            var actual = Employee.CreateEmployeeListFromLines(lines);

            //assert
            Assert.IsNotNull(actual);
            Assert.AreNotEqual(lines, actual);
        }


    }
}
