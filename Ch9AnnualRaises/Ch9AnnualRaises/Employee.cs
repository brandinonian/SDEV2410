namespace Ch9AnnualRaises
{
    internal partial class Program
    {
        struct Employee
        {
            private string firstName;
            private string lastName;
            private string payCategory;
            private double payRate;
            private Date hireDate;

            public Employee(string firstName, string lastName, string payCategory, double payRate, int hireMonth, int hireDay, int hireYear)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.payCategory = payCategory;
                this.payRate = payRate;
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
                int totalYears = year - hireDate.GetYear();
                double meritRaise = (merit * 0.01) * payRate;
                double loyaltyRaise = ((loyalty * 0.01) * totalYears) * payRate;
                payRate = meritRaise + loyaltyRaise + payRate;
            }
        }
    }
}