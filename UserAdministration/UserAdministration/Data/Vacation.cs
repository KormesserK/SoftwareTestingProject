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
        private static string c_FileName = "Vacation.csv";

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
            double numberOfDays = (lastDay - firstDay).TotalDays+1;
            for (int i = 0; i < numberOfDays; i++)
            {
                if (date.DayOfWeek.ToString() != "Saturday" && date.DayOfWeek.ToString() != "Sunday")
                    cnt += 1;

                date = date.AddDays(1);

            }
            return cnt;
        }



        public bool CheckRequest(string id)
        {
            var allLines = File.ReadLines(c_FileName);
            var availableDays = 0;
            foreach (var line in allLines)
            {
                var splitLine = line.Split(";");
                if (splitLine[0] == id)
                    availableDays = Int32.Parse(splitLine[1]);
            }
            
            
            if (availableDays!=0 && Count()<=availableDays)
                return true;
            return false;
        }

        private static void CheckIfFileExists_IfNot_Create()
        {
            if (!File.Exists(c_FileName))
            {
                Console.WriteLine("new File created");
                File.WriteAllText(c_FileName, "");
            }
        }

        public static void WriteEmployeeToCSV(string employeeid)
        {
            CheckIfFileExists_IfNot_Create();
            var csvLine = new List<string>();
            csvLine.Add(employeeid + ";25");
            File.AppendAllLines(c_FileName, csvLine);
        }


    }
}
