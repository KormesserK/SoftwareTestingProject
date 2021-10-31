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
    class CountTests
    {
        [Test]
        public void TestCountOneVacationDay()
        {
            Vacation TestVacation = new Vacation();

            TestVacation.firstDay = new DateTime(2021, 10, 4);
            TestVacation.lastDay = new DateTime(2021, 10, 4);

            if (TestVacation.Count() == 1) Assert.Pass();
            else Assert.Fail();

        }
        [Test]
        public void TestCountWeekendVacationDay()
        {
            Vacation TestVacation = new Vacation();

            TestVacation.firstDay = new DateTime(2021, 10, 3);
            TestVacation.lastDay = new DateTime(2021, 10, 3);

            if (TestVacation.Count() == 0) Assert.Pass();
            else Assert.Fail();

        }
        [Test]
        public void TestCountOneVacationWeek()
        {
            Vacation TestVacation = new Vacation();

            TestVacation.firstDay = new DateTime(2021, 10, 4);
            TestVacation.lastDay = new DateTime(2021, 10, 10);

            if (TestVacation.Count() == 5) Assert.Pass();
            else Assert.Fail();

        }

    }
}
