using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch7BirthdayBonus
{
    internal class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private double payRate;
        private Date birthdate;

        private static double monthlyTotal = 0;
        private static double totalPay = 0;

        public Employee(int id, string firstName, string lastName, double payRate, int month, int day, int year)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.payRate = payRate;
            this.birthdate = new Date(month, day, year);
            this.DisplayInfo();
        }

        public string GetFullName() { return this.firstName + " " + this.lastName; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee {this.id}, {this.GetFullName()}, birthday {this.birthdate.getDate()}, pay rate {this.payRate:C}");
        }

        public double CalculatePay(double hours, int month)
        {
            if (this.birthdate.getMonth() == month)
            {
                double grossPay = (this.payRate * (hours * 4)) + 100;
                Console.WriteLine($"Gross Pay for {this.GetFullName()}: {grossPay:C} with birthday bonus");
                return grossPay;
            }
            else
            {
                double grossPay = this.payRate * (hours * 4);
                Console.WriteLine($"Gross Pay for {this.GetFullName()}: {grossPay:C}");
                return grossPay;
            }
        }

        public static void setMonthlyTotal(double grossPay) { monthlyTotal = grossPay; }
        public static double getMonthlyTotal() { return monthlyTotal; }
        public static void displayMonthlyTotal()
        {
            Console.WriteLine($"\nTotal pay for this month: {monthlyTotal:C}");
        }
        public static void setTotalPay(double grossPay) { totalPay += grossPay; }
        public static double getTotalPay() { return totalPay; }
        public static void displayTotalPay()
        {
            Console.WriteLine($"\nTotal pay for all months: {totalPay:C}");
        }
    }
}
