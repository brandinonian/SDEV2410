struct Employee
{
    static double totalPay;

    private string firstName, lastName;
    private double payRate, hours;

    public Employee(string firstName, string lastName, double payRate, double hours)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.payRate = payRate;
        this.hours = hours;
    }

    public string GetFullName() => firstName + " " + lastName;

    public string Display() => $"{GetFullName()}: pay rate {payRate:C}, worked {hours} hours";

    public double CalcPay()
    {
        if (hours > 40)
        {
            double grossPay = ((hours - 40) * (payRate * 1.5)) + (40 * payRate);
            totalPay += grossPay;
            return grossPay;
        }
        else
        {
            double grossPay = hours * payRate;
            totalPay += grossPay;
            return grossPay;
        }
    }

    static public string GetTotalPay() => totalPay.ToString();
}