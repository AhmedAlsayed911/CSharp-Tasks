using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyEventsHandler.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public int WrongBehvioursCounter { get; private set; }

        public event Action<int>? EmployeeEventHandler;
        public void UpdateWrongCounter ()
        {
            WrongBehvioursCounter++;

            if(WrongBehvioursCounter >= 3)
                EmployeeEventHandler?.Invoke(this.Id);
        }

        public override string ToString()
        {
            return $"ID : {Id}\n" +
                $"Name : {Name}\n" +
                $"Salary : {Salary}\n" +
                $"Wrong Behaviours Counter : {WrongBehvioursCounter}\n";
        }
    }
}
