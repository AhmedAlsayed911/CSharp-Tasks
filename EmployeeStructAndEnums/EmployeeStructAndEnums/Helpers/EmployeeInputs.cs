using EmployeeStructAndEnums.Enums;
using EmployeeStructAndEnums.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStructAndEnums.Helpers
{
    /// <summary>
    /// Provides methods to read employee data from the user with full error handling.
    /// </summary>
    internal class EmployeeInputs
    {
        /// <summary>
        /// Reads all employee data from the user with complete error handling.
        /// No runtime errors will occur due to invalid input.
        /// </summary>
        /// <returns>A fully populated Employee struct.</returns>
        public static Employee ReadEmployee()
        {
            Employee e = new Employee();


            while (true)
            {
                Console.Write("Enter Employee ID: ");
                if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
                {
                    e.Id = id;
                    break;
                }
                Console.WriteLine("Invalid ID! Please enter a positive integer.");
            }


            while (true)
            {
                Console.Write("Enter Employee Salary: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal salary) && salary >= 3000)
                {
                    e.Salary = salary;
                    break;
                }
                Console.WriteLine("Invalid Salary! Please enter a value of at least 3000.");
            }


            //while (true)
            //{
            //    Console.Write("Enter Gender (M/F): ");
            //    string input = Console.ReadLine()?.Trim().ToUpper() ?? "";


            //    if (input == "MALE")
            //        input = "M";
            //    else if (input == "FEMALE")
            //        input = "F";

            //    try
            //    {
            //        e.Gender = (Gender)Enum.Parse(typeof(Gender), input, ignoreCase: true);
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid Gender! Please enter M or F.");
            //    }
            //}


            while (true)
            {
                Console.Write("Enter Gender (M/F): ");
                if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out Gender g) && (g == Gender.M || g == Gender.F))
                {
                    e.Gender = g;
                    break;
                }
                else
                    Console.WriteLine("Invalid Gender! Please enter M or F.");
            }

            while (true)
            {
                Console.Write("Enter Hire Date (dd/MM/yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                {
                    e.HireDate = new HiringDate(date.Day, date.Month, date.Year);
                    break;
                }
                Console.WriteLine("Invalid Date! Please enter a valid date (15/06/2023).");
            }


            while (true)
            {
                Console.WriteLine("Enter Security Level:");
                Console.WriteLine("  0 = None, 1 = Guest, 2 = Developer, 4 = Secretary, 8 = DBA, 15 = All");
                Console.Write("Enter value (0-15): ");
                if (byte.TryParse(Console.ReadLine(), out byte level) && level <= 15)
                {
                    e.SecurityLevel = (SecurityPreviliges)level;
                    break;
                }
                Console.WriteLine("Invalid Security Level! Please enter a value between 0 and 15.");
            }

            return e;
        }
    }
}
