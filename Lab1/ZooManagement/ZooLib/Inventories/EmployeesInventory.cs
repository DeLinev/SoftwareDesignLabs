using ZooLib.Employees;

namespace ZooLib.Inventories
{
    public class EmployeesInventory
    {
        private List<Employee> _employees;

        public EmployeesInventory(List<Employee> employees)
        {
            _employees = employees;
        }

        public void DisplayEmployees()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Role: {employee.Role.GetType().Name}");
            }
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void StartWork()
        {
            foreach (var employee in _employees)
            {
                employee.Work();
            }
        }

        public int GetEmployeesCount()
        {
            return _employees.Count;
        }
    }
}
