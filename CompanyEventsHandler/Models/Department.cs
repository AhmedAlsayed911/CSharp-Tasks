using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompanyEventsHandler.Models
{
    internal class Department : IEnumerable<Employee>
    {
        List<Employee> _employees = new List<Employee>();
        public int Id { get; set; }
        public string? Name { get; set; }

        public void AddEmployee(Employee e)
        {
            var employee = _employees.SingleOrDefault(x => x.Id == e.Id);

            if (employee is not null)
                Console.WriteLine("This Employee already exist!!");
            else
            {
                _employees.Add(e);
                e.EmployeeEventHandler += RemoveEmployee;
            }
        }

        public IEnumerator<Employee> GetEnumerator() => _employees.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private void RemoveEmployee(int id)
        {
            var employee = _employees.SingleOrDefault(x => x.Id == id);
            if (employee is not null)
            {
                _employees.Remove(employee);
                Console.WriteLine($"Employee with ID : {id} Removed from {Name} Department Successfully!!");
            }
            else
                Console.WriteLine($"Employee with ID : {id} is not Existed!!");
        }
    }
}
