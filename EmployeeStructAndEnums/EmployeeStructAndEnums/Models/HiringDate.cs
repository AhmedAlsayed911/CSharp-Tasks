using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeStructAndEnums.Models
{
    internal struct HiringDate
    {
        private int _day;
        private int _month;
        private int _year;

        public HiringDate(int day , int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
            get => _day;
            set
            {
                if (value < 1 || value > 31)
                    Console.WriteLine("Invalid Day!!");
                _day = value;
            }
        }

        public int Month
        {
            get => _month;
            set
            {
                if (value < 1 || value > 12)
                    Console.WriteLine("Invalid Month!!");
                _month = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    Console.WriteLine("Invalid Year!!");
                _year = value;
            }
        }
    }
}
