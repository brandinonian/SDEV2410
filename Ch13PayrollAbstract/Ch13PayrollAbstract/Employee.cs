using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13PayrollAbstract
{
    abstract class Employee
    {
        private int id;
        private string firstName;
        private string lastName;

        public static double totalPay = 0;

        protected Employee(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int getId() => id;
        public string getName() => $"{firstName} {lastName}";

        public override string ToString()
        {
            return $"{id} {getName()}";
        }

        public abstract double CalculatePay();
    }
}
