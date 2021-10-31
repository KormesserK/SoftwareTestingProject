using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Data;
using UserAdministration.Pages;

namespace VacationAdministration.Test
{
    class CheckRequestTests
    {
        [SetUp]
        public void Setup()
        {
            AddEmployee testEmployee = new AddEmployee();

            testEmployee.Employee.Firstname = "VacationTest";
            testEmployee.Employee.Lastname = "Employee";
            testEmployee.Employee.SocialSecurityNumber = "1234";
            testEmployee.Employee.Birthdate = new DateTime(1999, 12, 1);
            testEmployee.Employee.IsActive = true;
            testEmployee.Employee.VacDays = 25;
            testEmployee.HandleValidSubmit();

            AddEmployee testEmployee2 = new AddEmployee();

            testEmployee2.Employee.Firstname = "VacationTest2";
            testEmployee2.Employee.Lastname = "Employee";
            testEmployee2.Employee.SocialSecurityNumber = "1234";
            testEmployee2.Employee.Birthdate = new DateTime(1999, 12, 1);
            testEmployee2.Employee.IsActive = true;
            testEmployee2.Employee.VacDays = 0;
            testEmployee2.HandleValidSubmit();

            AddEmployee testEmployee4 = new AddEmployee();

            testEmployee4.Employee.Firstname = "VacationTest4";
            testEmployee4.Employee.Lastname = "Employee";
            testEmployee4.Employee.SocialSecurityNumber = "1234";
            testEmployee4.Employee.Birthdate = new DateTime(1999, 12, 1);
            testEmployee4.Employee.IsActive = true;
            testEmployee4.Employee.VacDays = 25;
            testEmployee4.HandleValidSubmit();
        }
        [Test]
        public void TestCheckRequestValid()
        {
            Vacation TestVacation = new Vacation();
            TestVacation.firstDay = new DateTime(2021, 10, 4);
            TestVacation.lastDay = new DateTime(2021, 10, 4);

            List<UserAdministration.Data.Employee> EmployeeList = UserAdministration.Data.Employee.ReadAllEmployees();
            Employee empBefore = EmployeeList[Employee.GetEmployeeIdx(EmployeeList, "1234VacationTest")];


            if (TestVacation.CheckRequest("1234VacationTest").Equals("Request accepted"))
            {
                List<UserAdministration.Data.Employee> EmployeeListNew = UserAdministration.Data.Employee.ReadAllEmployees();
                Employee empAfter = EmployeeListNew[Employee.GetEmployeeIdx(EmployeeList, "1234VacationTest")];
                if (empBefore.VacDays == (empAfter.VacDays + 1)) Assert.Pass();
                else Assert.Fail();
            }
            else Assert.Fail();

        }
        [Test]
        public void TestCheckRequestWeekend()
        {
            Vacation TestVacation = new Vacation();
            TestVacation.firstDay = new DateTime(2021, 10, 3);
            TestVacation.lastDay = new DateTime(2021, 10, 3);

            if (TestVacation.CheckRequest("1234VacationTest").Equals("Request rejected: this day(s) is (are) already off")) Assert.Pass();
            else Assert.Fail();
        }
        [Test]
        public void TestCheckRequestEmployeeWithoutVacation()
        {
            Vacation TestVacation = new Vacation();
            TestVacation.firstDay = new DateTime(2021, 10, 4);
            TestVacation.lastDay = new DateTime(2021, 10, 4);

            if (TestVacation.CheckRequest("1234VacationTest2").Equals("Request rejected: no more days off")) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void TestCheckRequestTooMuchVacation()
        {
            Vacation TestVacation = new Vacation();
            TestVacation.firstDay = new DateTime(2021, 10, 4);
            TestVacation.lastDay = new DateTime(2021, 11, 9);

            if (TestVacation.CheckRequest("1234VacationTest4").Equals("Request rejected: only 25 days off")) Assert.Pass();
            else Assert.Fail();
        }
    }

}
