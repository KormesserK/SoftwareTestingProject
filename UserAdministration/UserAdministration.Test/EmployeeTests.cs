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
 
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            //act
            var actual = newEmployee.ToCSVLine();

            //assert
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual("1234A;A;M;1234;1999,12,1;1;true", actual);
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
            IEnumerable<string> lines = Enumerable.Empty<string>();
            lines = lines.Append("1234A;A;M;1234;1999,12,1;True");
            lines = lines.Append("1239Ay;Ay;Me;1239;1995,10,17;False");
            


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
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;
            employeeList.Add(newEmployee2);

            
            //act
            var actual = Employee.CreateEmployeeListFromLines(lines);

            //assert
            Assert.AreEqual(employeeList.Last().ID, actual.Last().ID);
            Assert.AreEqual(employeeList.First().ID, actual.First().ID);

        }

        [Test]
        public void CreateEmployeeListFromLinesTest2()
        {
            //arrange

            IEnumerable<string> lines = Enumerable.Empty<string>();
            lines = lines.Append("1234A;A;M;1234;1999,12,1;True");
            lines = lines.Append("1239Ay;Ay;Me;1239;1995,10,17;False");


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
            newEmployee2.IsActive = true;
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;
            employeeList.Add(newEmployee2);


            //act
            var actual = Employee.CreateEmployeeListFromLines(lines);

            //assert
            Assert.AreNotEqual(employeeList.Last().IsActive, actual.Last().IsActive);
            Assert.AreEqual(employeeList.First().IsActive, actual.First().IsActive);
        }
        
        
        [Test]
        public void UpdateOverrideTest1()
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
            newEmployee2.IsActive = true;
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;
            employeeList.Add(newEmployee2);


            //act
            Employee newEmployee3 = new Employee();
            newEmployee3.Firstname = "Aya";
            newEmployee3.Lastname = "Met";
            newEmployee3.SocialSecurityNumber = "1239";
            newEmployee3.Birthdate = new DateTime(1995, 10, 17);
            newEmployee3.IsActive = true;
            newEmployee3.ID = "1239Ay";



            Employee.UpdateEmployee(employeeList, newEmployee3);
            var actual = Employee.ReadAllEmployees().Last();

            //assert
            Assert.AreNotEqual(newEmployee2.Firstname, actual.Firstname);
            Assert.AreEqual(newEmployee3.Firstname, actual.Firstname);
            Assert.AreNotEqual(newEmployee2.Lastname, actual.Lastname);
            Assert.AreEqual(newEmployee3.Lastname, actual.Lastname);
        }

        [Test]
        public void UpdateOverrideTest2()
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
            Employee.WriteEmployeeToCSV(newEmployee);

            Employee newEmployee2 = new Employee();
            newEmployee2.Firstname = "Ay";
            newEmployee2.Lastname = "Me";
            newEmployee2.SocialSecurityNumber = "1239";
            newEmployee2.Birthdate = new DateTime(1995, 10, 17);
            newEmployee2.IsActive = true;
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;
            employeeList.Add(newEmployee2);
            Employee.WriteEmployeeToCSV(newEmployee2);

            //act
            Employee newEmployee3 = new Employee();
            newEmployee3.Firstname = "Aya";
            newEmployee3.Lastname = "Met";
            newEmployee3.SocialSecurityNumber = "1239";
            newEmployee3.Birthdate = new DateTime(1995, 10, 17);
            newEmployee3.IsActive = true;
            newEmployee3.ID = "1";

            Employee.UpdateEmployee(employeeList, newEmployee3);
            var actual = Employee.ReadAllEmployees().Last();

            //assert
            Assert.AreEqual(newEmployee2.Firstname, actual.Firstname);
            Assert.AreNotEqual(newEmployee3.Firstname, actual.Firstname);
            Assert.AreEqual(newEmployee2.Lastname, actual.Lastname);
            Assert.AreNotEqual(newEmployee3.Lastname, actual.Lastname);
        }


    }
}
