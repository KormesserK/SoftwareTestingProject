using CsvHelper;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;

namespace UserAdministration.Data
{
    public class Employee : ComponentBase
    {
        private static string c_FileName = "\\Employee.csv";

        [Required]
        public string Firstname { get; set; } = "";

        [Required]
        public string Lastname { get; set; } = "";

        [Required]
        public string SocialSecurityNumber { get; set; } = "";

        [Required]
        public DateTime Birthdate { get; set; } = new DateTime(1900, 1, 1);

        public Employee(string firstname, string lastname, string socialSecurityNumber, 
            DateTime birthdate)
        {
            Firstname = firstname;
            Lastname = lastname;
            SocialSecurityNumber = socialSecurityNumber;
            Birthdate = birthdate;
        }

        public Employee()
        {
        }

        public bool AllPropertiesSet()
        {
            return (Firstname != "" && Lastname != "" && SocialSecurityNumber != "" && Birthdate != new DateTime(1900, 1, 1));
        }

        public string ToCSVLine()
        {
            return Firstname + ";" + Lastname + ";" + SocialSecurityNumber + ";" + Birthdate;
        }



        public static void WriteEmployeeToCSV(Employee employee)
        {
            CheckIfFileExists_IfNot_Create();
            var csvLines = new List<string>();
            csvLines.Add(employee.ToCSVLine());

            File.AppendAllLines(c_FileName, csvLines);            
        }

        private static void CheckIfFileExists_IfNot_Create()
        {
            if (!File.Exists(c_FileName))
            {
                string header = "Firstname;Lastname;SocialSecurityNumber;Birthdate";
                File.WriteAllText(c_FileName, header);
            }
        }

        public static List<Employee> ReadAllEmployees()
        {
            var allLines = File.ReadAllLines(c_FileName);
            List<Employee> employeeList = CreateEmployeeListFromLines(allLines);
            return employeeList;
        }

        private static List<Employee> CreateEmployeeListFromLines(string[] allLines)
        {
            var employeeList = new List<Employee>();

            foreach (var line in allLines)
            {
                var splitLine = line.Split(';');
                if (splitLine.Length != 4)
                {
                    throw new Exception("Error while reading file, the amount of arguments in this line is not correct");
                }

                var employee = new Employee(splitLine[0], splitLine[1], splitLine[3], Convert.ToDateTime(splitLine[4]));
                employeeList.Add(employee);
            }

            return employeeList;
        }
    }
}
