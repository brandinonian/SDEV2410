internal partial class Program
{
    struct Employee
    {
        private string firstName;
        private string lastName;
        private double payRate;
        private string payrollType;

        public Employee(string firstName, string lastName, double payRate, string payrollType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.payRate = payRate;
            this.payrollType = payrollType;
        }

        public string GetFullName() => firstName + " " + lastName;

        public double CalculatePay(double payRate)
        {
            return payRate / 52;
        }

        public double CalculatePay(double payRate, double hours)
        {
            if (hours > 40)
            {
                double basePay = payRate * 40;
                return basePay + ((hours - 40) * (payRate * 1.5));
            }
            else
            {
                return payRate * hours;
            }
        }
    }
}