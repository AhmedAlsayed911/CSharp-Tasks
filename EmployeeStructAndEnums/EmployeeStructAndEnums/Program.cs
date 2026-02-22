using EmployeeStructAndEnums.Enums;
using EmployeeStructAndEnums.Helpers;
using EmployeeStructAndEnums.Models;

namespace EmployeeStructAndEnums
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Employee emp = EmployeeInputs.ReadEmployee();

            Console.WriteLine(emp.ToString());

            Console.WriteLine("\nPress to Exit ");
            Console.ReadKey();


            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee
            {
                Id = 1,
                Salary = 8000,
                Gender = Gender.M,
                HireDate = new HiringDate(10, 5, 2020),
                SecurityLevel = SecurityPreviliges.DBA
            };

            EmpArr[1] = new Employee
            {
                Id = 2,
                Salary = 4000,
                Gender = Gender.F,
                HireDate = new HiringDate(15, 6, 2022),
                SecurityLevel = SecurityPreviliges.Guest
            };

            EmpArr[2] = new Employee
            {
                Id = 3,
                Salary = 12000,
                Gender = Gender.M,
                HireDate = new HiringDate(1, 1, 2019),

                SecurityLevel =
                    SecurityPreviliges.Guest |
                    SecurityPreviliges.Develpoer |
                    SecurityPreviliges.Secretary |
                    SecurityPreviliges.DBA
            };

            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                for (int j = 0; j < EmpArr.Length - 1 - i; j++)
                {
                    DateTime d1 = new DateTime(
                        EmpArr[j].HireDate.Year,
                        EmpArr[j].HireDate.Month,
                        EmpArr[j].HireDate.Day);

                    DateTime d2 = new DateTime(
                        EmpArr[j + 1].HireDate.Year,
                        EmpArr[j + 1].HireDate.Month,
                        EmpArr[j + 1].HireDate.Day);

                    if (d1 > d2)
                    {
                        Employee temp = EmpArr[j];
                        EmpArr[j] = EmpArr[j + 1];
                        EmpArr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("ID\tHireDate\t\tSalary\t\tGender\tSecurity");

            foreach (var e in EmpArr)
            {
                Console.WriteLine($"{e.Id}\t{e.HireDate.Day:D2}/{e.HireDate.Month:D2}" +
                    $"/{e.HireDate.Year}\t{e.Salary:C}\t{e.Gender}\t{e.SecurityLevel}");
            }

        }
    }
}
