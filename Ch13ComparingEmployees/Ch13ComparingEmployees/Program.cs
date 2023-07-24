namespace Ch13ComparingEmployees
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ch. 13 Console Project: Comparing Employees by Brandon Phillips\n");

            // employee array
            List<Employee> employees = new List<Employee>();
            // hourly employees
            employees.Add(new Hourly("A145", "Abby", "Jacobson", 36.50m));
            employees.Add(new Hourly("B987", "Brandon", "Phillips", 28.25m));
            // salaried employees
            employees.Add(new Salaried("C567", "Charlie", "Day", 55000m));
            employees.Add(new Salaried("D928", "Dave", "Moss", 48000m));

            // display all employees
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
            }

            // compare like employees
            Console.WriteLine("\n--- Compare like employees ---");
            CompareSalaries(employees[0], employees[1]);
            Console.Write("\n");
            CompareSalaries(employees[2], employees[3]);

            // compare unlike employees
            Console.WriteLine("\n--- Compare unlike employees ---");
            CompareSalaries(employees[1], employees[3]);
            Console.Write("\n");
            CompareSalaries(employees[2], employees[0]);

            // demo equal salaries with single employee
            Console.WriteLine("\n--- Compare the same employee ---");
            CompareSalaries(employees[3], employees[3]);

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void CompareSalaries(Employee emp1, Employee emp2)
        {
            // display employees
            Console.WriteLine($"1st employee: {emp1.ToString()}");
            Console.WriteLine($"2nd employee: {emp2.ToString()}");

            // compare salaries, type comparison handled in method
            int result = emp1.CompareTo(emp2);
            Console.WriteLine($"Result of comparison: {result}");
            if (result < 0)
            {
                Console.WriteLine("2nd employee makes more than the 1st");
            }
            else if (result > 0)
            {
                Console.WriteLine("1st employee makes more than the 2nd");
            }
            else
            {
                Console.WriteLine("Both employees make the same amount");
            }

        }
    }
}