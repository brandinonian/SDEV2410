using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13PayrollAbstract
{
    internal class Hourly : Employee
    {
        private double payRate;
        private double hours;

        public Hourly(int id, string firstName, string lastName, double payRate, double hours)
            : base(id, firstName, lastName)
        {
            this.payRate = payRate;
            this.hours = hours;
        }

        public override string ToString()
        {
            return $"\nHourly employee: {base.ToString()}\n" +
                $"   hourly pay rate: {payRate}%\n" +
                $"   hours worked: {hours}\n" +
                $"   earned: {CalculatePay():C}";
        }

        // calculate pay method
        public override double CalculatePay()
        {
            double grossPay;

            // calculate overtime pay
            if (hours > 40)
            {
                double overtime = (hours - 40) * (payRate * 1.5);
                grossPay = (payRate * 40) + overtime;
            }
            // calculate standard pay
            else
            {
                grossPay = payRate * hours;
            }
            Employee.totalPay += grossPay;
            return grossPay;
        }
    }
}
