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
        private static string c_FileName = "Employee.csv";

        //gets set somehow.
        public string ID { get; set; }

        [Required]
        public string Firstname { get; set; } = "";

        [Required]
        public string Lastname { get; set; } = "";

        [Required]
        public string SocialSecurityNumber { get; set; } = "";

        [Required]
        public DateTime Birthdate { get; set; } = new DateTime(1900, 1, 1);

        [Required]
        public bool IsActive { get; set; } = false;

        public Employee(string firstname, string lastname, string socialSecurityNumber, 
            DateTime birthdate, bool isActive)
        {
            Firstname = firstname;
            Lastname = lastname;
            SocialSecurityNumber = socialSecurityNumber;
            Birthdate = birthdate;
            IsActive = isActive;
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
            return Firstname + ";" + Lastname + ";" + SocialSecurityNumber + ";" + Birthdate.Year + "," + Birthdate.Month + "," + Birthdate.Day + ";" + IsActive;
        }



        public static void WriteEmployeeToCSV(Employee employee)
        {
            Console.WriteLine("Write Employee: " + employee.ToCSVLine());
            CheckIfFileExists_IfNot_Create();
            var csvLines = new List<string>();
            csvLines.Add(employee.ToCSVLine());

            File.AppendAllLines(c_FileName, csvLines);            
        }

        private static void CheckIfFileExists_IfNot_Create()
        {
            if (!File.Exists(c_FileName))
            {
                Console.WriteLine("new File created");
                File.WriteAllText(c_FileName, "");
            }
        }

        public static List<Employee> ReadAllEmployees()
        {
            try
            {
                var allLines = File.ReadLines(c_FileName);
                List<Employee> employeeList = CreateEmployeeListFromLines(allLines);
                return employeeList;
            }catch (Exception)
            { 
                return new List<Employee>();
            }
        }

        private static List<Employee> CreateEmployeeListFromLines(IEnumerable<string> allLines)
        {
            var employeeList = new List<Employee>();

            foreach (var line in allLines)
            {
                var splitLine = line.Split(';');
                if (splitLine.Length != 5)
                {
                    throw new Exception("Error while reading file, the amount of arguments in this line is not correct");
                }

                var birthdate = splitLine[3].Split(',');
                var employee = new Employee(splitLine[0], splitLine[1], splitLine[2], 
                    new DateTime(Convert.ToInt32(birthdate[0]), Convert.ToInt32(birthdate[1]), Convert.ToInt32(birthdate[2])), Convert.ToBoolean(splitLine[5]));
                employeeList.Add(employee);
            }

            return employeeList;
        }

        public static void UpdateEmployee(Employee employee)
        {
            //not yet supported.
        }
    }
}
