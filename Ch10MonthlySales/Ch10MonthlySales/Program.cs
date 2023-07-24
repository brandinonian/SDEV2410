internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch. 10 Console Project: Monthly Sales (using 2D array) by Brandon Phillips");

        string[] employees = { "1234 Brandon Phillips", "9876 George Carlin", "5678 Lance Wood", "4682 Dylan Ryver" };
        double[,] sales =
        {
            {51.3, 48.3, 50.5 },
            {66.6, 58.4, 61.2 },
            {45.5, 51.2, 59.8 },
            {28.7, 55.9, 37.5 }
        };
        string reply = "";

        // display all sales
        for (int employee = 0; employee < employees.Length; employee++)
        {
            Console.WriteLine($"{employees[employee]}:\t\t{sales[employee, 0]:C}\t\t{sales[employee, 1]:C}\t\t{sales[employee, 2]:C}");
        }

        // user selection loop
        do
        {
            Console.Write("\nPrint (s)Sales totals for staff, (m)Monthly sales total, (x)Exit: ");
            reply = Console.ReadLine();
            if (reply == "s")
            {
                for (int employee = 0; employee < employees.Length; employee++)
                {
                    Console.WriteLine($"{employees[employee]}:\t\t{(sales[employee, 0] + sales[employee, 1] + sales[employee, 2]):C}"); // totals the sales for each employee
                }
            }
            else if (reply == "m")
            {
                double quarterlySales = 0;
                for (int month = 0; month < sales.GetLength(1); month++) // sales.Length needs to be indexed for correct length
                {
                    double monthlyTotal = sales[0, month] + sales[1, month] + sales[2, month] + sales[3, month]; // totals the sales for each month
                    quarterlySales += monthlyTotal;
                    Console.WriteLine($"Month {month + 1} sales:\t\t\t{monthlyTotal:C}");
                }
                Console.WriteLine($"Total quarterly sales:\t\t{quarterlySales:C}");
            }
            else if (reply == "x")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry, try again");
            }
        } while (reply != "x");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}