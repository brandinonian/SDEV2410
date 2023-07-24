using Ch7CashRegister;
using System.Diagnostics;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Ch 7 Console Project: Cash Register by Brandon Phillips\n");

        CashRegister register1 = new CashRegister();

        string reply;
        do
        {
            // gather user data
            Write("\nWhat is the cost? $");
            double cost = double.Parse(ReadLine());
            Write("How much money from the customer? $");
            double cash = double.Parse(ReadLine());
            // calculate change            
            try
            {
                double change = register1.NewSale(cost, cash);
                WriteLine($"The change is {change:C}");
            }
            catch (Exception ex) // error message if customer doesn't pay enough
            {
                WriteLine(ex.Message);
            }
            // check for more data
            Write("More purchases? (y/n) ");
            reply = ReadLine();
        }
        while (reply == "y");
        register1.DisplayTotalSales();
        // exit program
        WriteLine("\nPress any key to exit...");
        ReadKey();
    }
}