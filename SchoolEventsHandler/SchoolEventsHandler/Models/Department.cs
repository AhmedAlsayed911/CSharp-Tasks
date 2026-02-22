using SchoolEventsHandler.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace SchoolEventsHandler.Models
{
    internal class Department : IEnumerable<Student>
    {
        List<Student> _students = new List<Student>();
        public int Id { get; set; }
        public string? Name { get; set; }

        public void AddStudent(Student s)
        {
            _students.Add(s);
            s.StudentFireEventHandler += RemoveStudent;
        }

        public IEnumerator<Student> GetEnumerator() => _students.GetEnumerator();

        public void RemoveStudent(Student s)
        {

            _students.Remove(s);

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
