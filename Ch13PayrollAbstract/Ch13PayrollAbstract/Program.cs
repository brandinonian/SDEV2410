using Ch13PayrollAbstract;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 13 Console Project: Payroll with Abstract Class by Brandon Phillips");

        // hardcoded employees
        List<Employee> employees = new List<Employee>();
        // hourly
        employees.Add(new Hourly(1234, "Brandon", "Phillips", 30, 40.00));
        employees.Add(new Hourly(9876, "Gavin", "Kent", 45, 29.5));
        // salaried
        employees.Add(new Salaried(5678, "Eric", "Thorup", 125000));
        employees.Add(new Salaried(4488, "Greg", "Kime", 48000));
        // commission
        employees.Add(new Commission(6189, "Dave", "Moss", 38000, 10));
        employees.Add(new Commission(3975, "John", "Wayne", 9750, 8));

        // loop through all employees in the list
        foreach (Employee e in employees)
        {
            Console.WriteLine(e.ToString());
        }

        // display total pay
        Console.WriteLine($"\nTotal Pay: {Employee.totalPay:C}");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}