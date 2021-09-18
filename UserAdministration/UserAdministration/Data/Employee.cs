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

        public static void WriteEmployeeToCSV(Employee employee)
        {
            CheckIfFileExists_IfNot_Create();


        }

        private static void CheckIfFileExists_IfNot_Create()
        {
            string newFileName = "\\Employee.csv";
            if (!File.Exists(newFileName))
            {
                string header = "Firstname;Lastname,SocialSecurityNumber;Birthdate";
                File.WriteAllText(header);
            }
        }
    }
}
