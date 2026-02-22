using CompanyEventsHandler.Models;

namespace CompanyEventsHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee { Id = 1 , Name = "Ahmed" , Salary = 100000};
            var employee2 = new Employee { Id = 2 , Name = "Khaled" , Salary = 40000};
            var employee3 = new Employee { Id = 3 , Name = "Aly" , Salary = 150000};

            var OS = new Department { Id = 1, Name = "OS" };
            var club = new Club { Id = 1, Name = "AlAhly SC" };

            OS.AddEmployee(employee1);
            OS.AddEmployee(employee2);
            OS.AddEmployee(employee3);

            club.AddEmployee(employee1);
            club.AddEmployee(employee2);
            club.AddEmployee(employee3);

            employee1.UpdateWrongCounter();
            employee1.UpdateWrongCounter();
            employee1.UpdateWrongCounter();

            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var emp in OS)
                Console.WriteLine(emp);

            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var emp in club)
                Console.WriteLine(emp);
        }
    }
}
