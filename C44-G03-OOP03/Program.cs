namespace C44_G03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.	Design and implement a Class for the employees in a company
            //Employee employee;
            //employee = new Employee(1, "Mahmoud", SecurityLevel.Developer, 8500.00m, new DateTime(2024, 1, 22), 'M');

            //Console.WriteLine(employee);
            #endregion

            #region Question 2 & 3 & 4
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ali", SecurityLevel.DBA, 15000m, new HireDate(12, 2, 2019), 'M');
            EmpArr[1] = new Employee(2, "Sara", SecurityLevel.Guest, 5000m, new HireDate(5, 7, 2021), 'F');
            EmpArr[2] = new Employee(3, "Omar", SecurityLevel.DBA, 18000m, new HireDate(25, 12, 2018), 'M');

            Console.WriteLine("Original Array:");
            foreach (var emp in EmpArr)
                Console.WriteLine(emp);

            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                for (int j = i + 1; j < EmpArr.Length; j++)
                {
                    if (EmpArr[i].HireDate.ToDateTime() > EmpArr[j].HireDate.ToDateTime())
                    {
                        Employee temp = EmpArr[i];
                        EmpArr[i] = EmpArr[j];
                        EmpArr[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Array by Hire Date:");
            foreach (var emp in EmpArr)
                Console.WriteLine(emp);

            Console.WriteLine("\nNumber of Boxing/Unboxing operations: 0");


            #endregion
        }
    }
}
