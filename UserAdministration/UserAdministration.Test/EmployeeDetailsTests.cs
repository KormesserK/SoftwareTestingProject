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
    class EmployeeDetailsTests
    {
        [Test]
        public void ShowTest1()
        {
            //arrange
            EmployeeDetails EmDetails = new EmployeeDetails();
            EmDetails.EmployeeList = new List<Employee>();

            Employee newEmployee = new Employee();
            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            EmDetails.EmployeeList.Add(newEmployee);

            Employee newEmployee2 = new Employee();
            newEmployee2.Firstname = "Ay";
            newEmployee2.Lastname = "Me";
            newEmployee2.SocialSecurityNumber = "1239";
            newEmployee2.Birthdate = new DateTime(1995, 10, 17);
            newEmployee2.IsActive = true;
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;

            EmDetails.EmployeeList.Add(newEmployee2);

            Employee newEmployee3 = new Employee();
            newEmployee3.Firstname = "Aya";
            newEmployee3.Lastname = "Met";
            newEmployee3.SocialSecurityNumber = "1239";
            newEmployee3.Birthdate = new DateTime(1995, 10, 17);
            newEmployee3.IsActive = true;
            newEmployee3.ID = "1239Ay";

            EmDetails.EmployeeList.Add(newEmployee3);

            EmDetails.ShownEmployee = newEmployee2;

            //act
            EmDetails.ShowLastEmployee();
            var actual = EmDetails.ShownEmployee;



            //assert
            
            Assert.AreEqual(newEmployee, actual);
        }

        [Test]
        public void ShowTest2()
        {
            //arrange
            EmployeeDetails EmDetails = new EmployeeDetails();
            EmDetails.EmployeeList = new List<Employee>();

            Employee newEmployee = new Employee();
            newEmployee.Firstname = "A";
            newEmployee.Lastname = "M";
            newEmployee.SocialSecurityNumber = "1234";
            newEmployee.Birthdate = new DateTime(1999, 12, 1);
            newEmployee.IsActive = true;
            newEmployee.ID = newEmployee.SocialSecurityNumber + newEmployee.Firstname;

            EmDetails.EmployeeList.Add(newEmployee);

            Employee newEmployee2 = new Employee();
            newEmployee2.Firstname = "Ay";
            newEmployee2.Lastname = "Me";
            newEmployee2.SocialSecurityNumber = "1239";
            newEmployee2.Birthdate = new DateTime(1995, 10, 17);
            newEmployee2.IsActive = true;
            newEmployee2.ID = newEmployee2.SocialSecurityNumber + newEmployee2.Firstname;

            EmDetails.EmployeeList.Add(newEmployee2);

            Employee newEmployee3 = new Employee();
            newEmployee3.Firstname = "Aya";
            newEmployee3.Lastname = "Met";
            newEmployee3.SocialSecurityNumber = "1239";
            newEmployee3.Birthdate = new DateTime(1995, 10, 17);
            newEmployee3.IsActive = true;
            newEmployee3.ID = "1239Ay";

            EmDetails.EmployeeList.Add(newEmployee3);

            EmDetails.ShownEmployee = newEmployee2;

            //act
            EmDetails.ShowNextEmployee();
            var actual = EmDetails.ShownEmployee;

            //assert
            Assert.AreEqual(newEmployee3, actual);
        }
    }
}
