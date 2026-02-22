using EmployeeStructAndEnums.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace EmployeeStructAndEnums.Models
{
    internal struct Employee
    {
        private int _id;
        private decimal _salary;
        private Gender _gender;
        private HiringDate _hireDate;
        private SecurityPreviliges _securityLevel;

        public Employee(int id, decimal salary, Gender gender, HiringDate date, SecurityPreviliges level)
        {
            Id = id;
            Salary = salary;
            Gender = gender;
            Date = date;
            SecurityLevel = level;
        }
        public int Id
        {
            get => _id;

            set
            {
                if (value <= 0)
                    Console.WriteLine("Cannot insert ID with '0' or Minus !!");
                else
                    _id = value;
            }
        }

        public decimal Salary
        {
            get => _salary;

            set
            {
                if (value < 3000)
                    Console.WriteLine($"Salary cannot be Less than {3000:C2}");
                else
                    _salary = value;
            }
        }

        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }
        public HiringDate Date { get; }
        public HiringDate HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        public SecurityPreviliges SecurityLevel
        {
            get => _securityLevel;
            set => _securityLevel = value;
        }

        public override string ToString()
        {

            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Salary: {Salary:C2}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Hire Date: {HireDate.Day:D2}/{HireDate.Month:D2}/{HireDate.Year}");
            Console.WriteLine($"Security Level: {SecurityLevel}");

            return "";
        }

    }
}
