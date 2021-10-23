using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UserAdministration.Data
{
    public class Vacation : ComponentBase

    {
        private static string c_FileName = "Employee.csv";

        [Required]
        public DateTime firstDay { get; set; } = DateTime.Now;

        [Required]
        public DateTime lastDay { get; set; } = DateTime.Now;

        public bool CheckDates()
        {
            var result = DateTime.Compare(firstDay, lastDay);
            if (result > 0)
                return false;
            return true;
        }

        public int Count()
        {
            int cnt = 0;
            DateTime date = firstDay;
            double numberOfDays = (lastDay - firstDay).TotalDays + 1;
            for (int i = 0; i < numberOfDays; i++)
            {
                if (date.DayOfWeek.ToString() != "Saturday" && date.DayOfWeek.ToString() != "Sunday")
                    cnt += 1;

                date = date.AddDays(1);

            }
            return cnt;
        }



        public string CheckRequest(string id)
        {
            var allLines = File.ReadLines(c_FileName);
            var availableDays = 0;
            foreach (var line in allLines)
            {
                var splitLine = line.Split(";");
                if (splitLine[0] == id)
                    availableDays = Int32.Parse(splitLine[6]);
            }

            int reqDays = Count();
            if (reqDays == 0)
            {
                return "Request rejected: this day(s) is (are) already off";
            }
            if (availableDays == 0)
                return "Request rejected: no more days off";
            else if (reqDays > availableDays)
                return "Request rejected: only " + availableDays + " days off";
            else
            {
                UpdateVaccation(id, reqDays);
                return "Request accepted";
            }



        }

        private static void UpdateVaccation(string id, int reqDays)
        {
            List<Data.Employee> EmployeeList = Data.Employee.ReadAllEmployees();
            Employee newEmployee = EmployeeList[Employee.GetEmployeeIdx(EmployeeList, id)];
            newEmployee.VacDays -= reqDays;
            Employee.UpdateEmployee(EmployeeList, newEmployee);
        }
    }
}
