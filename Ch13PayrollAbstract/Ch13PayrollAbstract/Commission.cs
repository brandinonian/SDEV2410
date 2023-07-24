using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13PayrollAbstract
{
    internal class Commission : Employee
    {
        private double sales;
        // pay rate changed to percentage at time of calculation
        private int payRate;

        public Commission(int id, string firstName, string lastName, double sales, int payRate)
            : base(id, firstName, lastName)
        {
            this.sales = sales;
            this.payRate = payRate;
        }

        public override string ToString()
        {
            return $"\nCommission employee: {base.ToString()}\n" +
                $"   commission rate: {payRate}%\n" +
                $"   sales: {sales:C}\n" +
                $"   earned: {CalculatePay():C}";
        }

        // calculate pay method
        public override double CalculatePay()
        {
            double grossPay = sales * (payRate * .01);
            Employee.totalPay += grossPay;
            return grossPay;
        }
    }
}
