using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13ComparingEmployees
{
    class Employee : IComparable
    {
        private string id;
        private string firstName;
        private string lastName;
        private decimal payRate;

        public Employee(string id, string firstName, string lastName, decimal payRate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.payRate = payRate;
        }

        public string GetName() => $"{firstName} {lastName}";
        public decimal GetPayRate() => payRate;
        public override string ToString()
        {
            return $"{id} {GetName()}";
        }

        public int CompareTo(object obj)
        {
            decimal objAnnualPay;
            decimal thisAnnualPay;
            Employee emp = (Employee)obj;
            
            // if current object is hourly calculate annual pay
            if (this is Hourly)
            {
                thisAnnualPay = (this.GetPayRate() * 2080);
            }
            else { thisAnnualPay = this.GetPayRate(); }

            // if parameter object is hourly calculate annual pay
            if (obj is Hourly)
            {
                objAnnualPay = (emp.GetPayRate() * 2080);
            }
            else { objAnnualPay = emp.GetPayRate(); }

            // compare annual salaries
            if (thisAnnualPay < objAnnualPay)
            {
                return -1;
            }
            else if (thisAnnualPay > objAnnualPay)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
    }
}
