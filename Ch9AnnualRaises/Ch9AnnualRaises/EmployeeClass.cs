using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9AnnualRaises
{
    internal class EmployeeClass
    {
        private string firstName;
        private string lastName;
        private string payCategory;
        private double payRate;
        private int hireMonth;
        private int hireDay;
        private int hireYear;
        private Date hireDate;

        public EmployeeClass(string firstName, string lastName, string payCategory, double payRate, int hireMonth, int hireDay, int hireYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.payCategory = payCategory;
            this.payRate = payRate;
            this.hireMonth = hireMonth;
            this.hireDay = hireDay;
            this.hireYear = hireYear;
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public string Display()
        {
            return $"{GetFullName()}, {payCategory}, hired {hireDate}, pay rate {payRate:C}";
        }

        public void CalculateRaise(int year, int merit, int loyalty)
        {
            int years = year - hireYear;
            double meritRaise = (merit * 0.01) * payRate;
            double loyaltyRaise = ((loyalty * 0.01) * years) * payRate;
            payRate = meritRaise + loyaltyRaise + payRate;
        }
    }
}
