namespace C44_G03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.	Design and implement a Class for the employees in a company:
            Employee employee;
            employee = new Employee(1, "Mahmoud", SecurityLevel.Developer, 8500.00m, new DateTime(2024, 1, 22), 'M');

            Console.WriteLine(employee);
            #endregion
        }
    }
}
