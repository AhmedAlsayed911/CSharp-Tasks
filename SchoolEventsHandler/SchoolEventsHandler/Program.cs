using SchoolEventsHandler.Models;

namespace SchoolEventsHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student { Id = 1 , Name = "Ziad"};
            var student2 = new Student { Id = 2 , Name = "Yasser"};
            var student3 = new Student { Id = 3 , Name = "Aly"};

            var OS = new Department { Id = 1 , Name = "OS"};
            var AI = new Department { Id = 2 , Name = "AI"};
            
            OS.AddStudent(student1);
            OS.AddStudent(student2);
            OS.AddStudent(student3);

            student1.UpdateAbsentDays();
            student1.UpdateAbsentDays();
            student1.UpdateAbsentDays();
            student1.UpdateAbsentDays();

            

            foreach (var student in OS)
                Console.WriteLine(student);
        }   
    }
}
