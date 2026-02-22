using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolEventsHandler.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AbsentDays { get; private set; }

        public void UpdateAbsentDays()
        {
            AbsentDays++;

            if (AbsentDays >= 4)
                StudentFireEventHandler?.Invoke(this);
        }

        public event Action<Student>? StudentFireEventHandler;

        public override string ToString()
        {
            return $"ID : {Id} \n" +
                $"Name : {Name} \n" +
                $"Absent Days : {AbsentDays}  \n";
        }
    }
}
