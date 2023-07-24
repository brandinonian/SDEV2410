internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 10 Console Project: Employee Payroll Array by Brandon Phillips"); // header

        int size = 5;
        Employee[] employees = new Employee[size];

        int empID;
        string fname, lname, answer;
        double payRate, hours;
        Boolean repeat = false;

        // user input
        Console.Write("\nInput employee data");
        for (int a  = 0; a < size; a++)
        {
            Console.WriteLine($"\nFor employee # {a + 1}");
            Console.Write("Enter fisrt name: ");
            fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            lname = Console.ReadLine();
            Console.Write("Enter rate of pay: $");
            try
            {
                payRate = double.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                payRate=0;
                Console.WriteLine($"{e.Message} Pay rate set to $0.00");
            }
            Console.Write("Enter hours worked: ");
            try
            {
                hours = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                hours = 0;
                Console.WriteLine($"{e.Message} Hours set to 0");
            }
            employees[a] = new Employee(fname, lname, payRate, hours);
        }
        Console.WriteLine("\nPayroll");
        foreach (Employee e in employees)
        {
            double grossPay = e.CalcPay();
            Console.WriteLine($"{e.Display()}, gross pay = {grossPay:C}");
        }
        Console.WriteLine($"\nTotal Pay ${Employee.GetTotalPay()}");

        Console.WriteLine("\nPress any key to exit..."); // exit program
        Console.ReadKey();
    }
}