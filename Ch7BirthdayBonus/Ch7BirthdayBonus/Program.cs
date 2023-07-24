using Ch7BirthdayBonus;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 7 Console Project: Birthday Bonus, Payroll with Date by Brandon Phillips\n");

        // create employees
        Employee employee0 = new Employee(48372, "Brandon", "Phillips", 10.25, 3, 10, 1996);
        Employee employee1 = new Employee(83734, "Ann", "Adams", 12, 1, 16, 1990);
        Employee employee2 = new Employee(23828, "Carol", "Cross", 11, 2, 3, 1993);

        // for loop
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"\nCalculating pay for month {i}");
            double totalPay = 0;
            totalPay += employee0.CalculatePay(38.5, i);
            totalPay += employee1.CalculatePay(40, i);
            totalPay += employee2.CalculatePay(42, i);
            Employee.setMonthlyTotal(totalPay);
            Employee.setTotalPay(totalPay);
            // display monthly total
            Employee.displayMonthlyTotal();
        }
        // display grand total
        Employee.displayTotalPay();

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();



    }
}