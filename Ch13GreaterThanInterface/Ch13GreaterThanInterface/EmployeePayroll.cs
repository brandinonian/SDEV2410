using System;
namespace Ch13GreaterThanInterface
{
	public class EmployeePayroll : IGreater
	{
        private int id, hours;
        private double payRate, grossPay;

        public EmployeePayroll(int id, int hours, double payRate)
        {
            this.id = id;
            this.hours = hours;
            this.payRate = payRate;
            this.grossPay = payRate * hours;
        }

        public void SetHours(int h)
        {
            // update hours and gross pay
            hours = h;
            grossPay = payRate * hours;
        }

        public override string ToString()
        {
            return $"Employee {id}: rate {payRate:C}, hours worked {hours}, gross pay {grossPay:C}";
        }

        public bool IsGreater(object obj)
        {
            // cast to employee payroll type
            EmployeePayroll e = (EmployeePayroll)obj;

            // compare gross pay, return true if "this" object has higher gross pay
            if (this.grossPay > e.grossPay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayGreater(object obj)
        {
            // cast parameter to employee payroll type
            EmployeePayroll e = (EmployeePayroll)obj;

            // display results
            Console.WriteLine($"Pay for employee {this.id} is greater than pay for employee {e.id}");
        }
    }
}
