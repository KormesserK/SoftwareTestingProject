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
    public class CheckDatesTests
    {

        [Test]
        public void TestCheckPosaitiveDateDifference()
        {
            Vacation TestVacation = new Vacation();

            TestVacation.firstDay = DateTime.Now;
            TestVacation.lastDay = DateTime.Now.AddDays(1);

            if (TestVacation.CheckDates()) Assert.Pass();
            else Assert.Fail();

        }
        [Test]
        public void TestCheckNegativeDateDifference()
        {
            Vacation TestVacation = new Vacation();

            TestVacation.firstDay = DateTime.Now;
            TestVacation.lastDay = DateTime.Now.AddDays(-1);

            if (!TestVacation.CheckDates()) Assert.Pass();
            else Assert.Fail();

        }
        [Test]
        public void TestCheckZeroDateDifference()
        {
            Vacation TestVacation = new Vacation();

            TestVacation.firstDay = DateTime.Now;
            TestVacation.lastDay = DateTime.Now;

            if (TestVacation.CheckDates()) Assert.Pass();
            else Assert.Fail();

        }
    }
}