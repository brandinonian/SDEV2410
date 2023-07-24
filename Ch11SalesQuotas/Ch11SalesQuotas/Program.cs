namespace Ch11SalesQuotas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ch 11 Console Project: Sales Quotas by Brandon Phillips");

            // hard coded
            // employees
            Employee[] employees = {
                new Employee("Brandon", "Phillips", 10000),
                new Employee("Adam", "Adams", 15000),
                new Employee("Dylan", "Ryver", 5000),
                new Employee("Sandy", "Desert", 12500),
                new Employee("John", "Jacobs", 11000)
            };

            // check quotas method calls
            CheckQuota(employees[0], 2150, 1200, 4575, 1200, 2600);
            CheckQuota(employees[1], 5500, 3950, 4500, 7200);
            CheckQuota(employees[2], 1100, 2100, 1850, 1300);
            CheckQuota(employees[3], 3000, 4200);
            CheckQuota(employees[4], 1400, 2300, 1150);

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void CheckQuota(Employee employee, params double[] sales)
        {
            double totalSales = 0;

            // Display the employees full name
            Console.WriteLine($"\nFor employee {employee.GetFullName()}, Sales amounts: ");

            // for each sale in sales array print the amount and add to the total
            foreach (double sale in sales)
            {
                Console.Write($"  {sale:C}");
                totalSales += sale;
            }

            // Print the total sales
            Console.WriteLine($"  Total Sales: {totalSales:C}");

            // check if the total sales are more than the quota, print messages accordingly
            if (totalSales >= employee.GetQuota())
            {
                Console.WriteLine($"Good job {employee.GetName()}! You met your quota of {employee.GetQuota():C}.");
            }
            else
            {
                Console.WriteLine($"{employee.GetName()}, you did not meet your quota of {employee.GetQuota():C}.");
            }
        }
    }
}