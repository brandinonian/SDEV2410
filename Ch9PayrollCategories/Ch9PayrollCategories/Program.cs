internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 9 Console Project: Payroll Categories using Struct by Brandon Phillips");

        // user input salaried employee
        Console.WriteLine("\nInput data for salaried employee");
        Console.Write("Enter first name: ");
        string firstNameS = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastNameS = Console.ReadLine();
        Console.Write("Enter annual salary: $");
        double payRateS;
        try
        {
            payRateS = double.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            payRateS = 0;
            Console.WriteLine(ex.Message);
        }
        Employee salaryEmp = new Employee(firstNameS, lastNameS, payRateS, "s");

        // user input hourly employee
        Console.WriteLine("\nInput data for hourly employee");
        Console.Write("Enter first name: ");
        string firstNameH = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastNameH = Console.ReadLine();
        Console.Write("Enter hourly pay: $");
        double payRateH;
        try
        {
            payRateH = double.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            payRateH = 0;
            Console.WriteLine(ex.Message);
        }
        Console.Write("Enter number of hours worked: ");
        double hoursH;
        try
        {
            hoursH = double.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            hoursH = 0;
            Console.WriteLine(ex.Message);
        }
        Employee hourlyEmp = new Employee(firstNameH, lastNameH, payRateH, "h");

        // calculate pay
        Console.WriteLine($"\nEmployee {salaryEmp.GetFullName()}, weekly pay: {salaryEmp.CalculatePay(payRateS):C}");
        Console.WriteLine($"\nEmployee {hourlyEmp.GetFullName()}, weekly pay: {hourlyEmp.CalculatePay(payRateH, hoursH):C}");


        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}