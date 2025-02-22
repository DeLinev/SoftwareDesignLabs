namespace ZooLib.Employees.Roles
{
    public class Veterinarian : IRole
    {
        public void PerformDuties()
        {
            Console.WriteLine("Examining and treating animals...");
        }
    }
}
