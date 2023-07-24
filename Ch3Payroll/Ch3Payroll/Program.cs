using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch3Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch 3 Console Project: Payroll by Brandon Phillips\n");

            string nameString = "";
            double grossPay = 0.0;

            nameString = getEmployeeName();
            grossPay = getEmployeeSalary();
            calculatePay(nameString, grossPay);

            nameString = getEmployeeName();
            grossPay = getEmployeeSalary();
            calculatePay(nameString, grossPay);

            nameString = getEmployeeName();
            grossPay = getEmployeeSalary();
            calculatePay(nameString, grossPay);

            // pause
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
            Write("What is the employee's rate of pay? $");
            double payRate = double.Parse(ReadLine());
            Write("How many hours did the employee work? ");
            double payHours = double.Parse(ReadLine());
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
