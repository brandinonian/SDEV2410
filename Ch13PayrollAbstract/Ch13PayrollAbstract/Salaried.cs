using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13PayrollAbstract
{
    internal class Salaried : Employee
    {
        private double salary;

        public Salaried (int id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"\nSalaried employee: {base.ToString()}\n" +
                $"   earned: {CalculatePay():C}";
        }

        // calculate pay method
        public override double CalculatePay()
        {
            double grossPay = salary / 52;
            Employee.totalPay += grossPay;
            return grossPay;
        }
    }
}
