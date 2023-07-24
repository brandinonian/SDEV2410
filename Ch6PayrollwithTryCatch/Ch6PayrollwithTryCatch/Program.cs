using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch6PayrollwithTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 6 Console Project: Payroll with Try/Catch by Brandon Phillips\n");

            // main loop
            string reply = "";
            do
            {
                // gather name data
                Write("\nEnter employee's first name: ");
                string firstName = ReadLine();
                Write("Enter employee's last name: ");
                string lastName = ReadLine();

                // calculate pay
                CalculatePay(firstName, lastName);

                // ask to process more data
                do
                {
                    Write("\nIs there another employee? (y/n) ");
                    reply = ReadLine();
                } while (reply != "n" && reply != "y");
            } while (reply == "y");

            // exit program
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
        static void CalculatePay(string firstName, string lastName)
        {
            try
            {
                // gather pay rate data
                Write("Enter employee's pay rate: ");
                double payRate = double.Parse(ReadLine());
                if (payRate < 8.00 || payRate > 40.00)
                {
                    throw new Exception("Invalid pay rate...");
                }
                Write("Enter employee's tax rate: ");
                double taxRate = double.Parse(ReadLine());
                if (taxRate < 5 || taxRate > 60)
                {
                    throw new Exception("Invalid tax rate...");
                }
                Write("Enter employee's hours worked: ");
                double hoursWorked = double.Parse(ReadLine());
                if (hoursWorked < 1 || hoursWorked > 60)
                {
                    throw new Exception("Invalid hours worked...");
                }
                // calculate and display par rate
                double grossPay = payRate * hoursWorked;
                double taxPaid = grossPay * (taxRate * 0.01);
                double netPay = grossPay - taxPaid;
                WriteLine($"{firstName} {lastName}: gross pay {grossPay:C}, net pay {netPay:C}");
            }
            catch (FormatException)
            {
                WriteLine("Incorrect input format...");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
