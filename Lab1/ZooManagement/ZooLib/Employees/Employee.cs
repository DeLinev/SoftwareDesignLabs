using System.Data;
using ZooLib.Employees.Roles;

namespace ZooLib.Employees
{
    public class Employee
    {
        public string Name { get; }
        public IRole Role { get; }

        public Employee(string name, IRole role)
        {
            Name = name;
            Role = role;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working:");
            Role.PerformDuties();
        }
    }
}
