using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch5PayrollLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 5 Console Project: Payroll Loop by Brandon Phillips\n");
            // payroll loop
            string reply = "";
            do
            {
                string nameString = getEmployeeName();
                double grossPay = getEmployeeSalary();
                calculatePay(nameString, grossPay);
                Write("Do you have another employee to process? (y/n) ");
                reply = ReadLine();
            } while (reply == "y");
            // exit program
            WriteLine("\nPress any key to continue...");
            ReadKey();

        }

        static string getEmployeeName()
        {
            Write("What is the employee's ID? ");
            string employeeID = ReadLine();
            Write("What is the employee's first name? ");
            string firstName = ReadLine();
            Write("What is the employee's last name? ");
            string lastName = ReadLine();
            return $"Payroll for {employeeID} {firstName} {lastName}";
        }

        static double getEmployeeSalary()
        {
            double payRate;
            do
            {
                Write("What is the employee's rate of pay? $");
                payRate = double.Parse(ReadLine());
            } while (payRate <= 1.00d || payRate >= 50.00d);
            double payHours;
            do
            {
                Write("How many hours did the employee work? ");
                payHours = double.Parse(ReadLine());
            } while (payHours <= 1.00d || payHours >= 60.00d);
            return payRate * payHours;
        }

        static void calculatePay(string employeeInfo, double grossSalary)
        {
            double calculateTax(double salary)
            {
                return salary * 0.075;
            }
            double ficaTax = calculateTax(grossSalary);
            WriteLine($"{employeeInfo}\n  Gross Pay: {grossSalary:C}\n  FICA tax:  {ficaTax:C}\n  Net Pay:   {(grossSalary - ficaTax):C}\n");
        }
    }
}
