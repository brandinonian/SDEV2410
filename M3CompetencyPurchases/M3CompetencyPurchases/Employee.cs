internal partial class Program
{
    struct Employee
    {
        private string firstName;
        private string lastName;
        private int id;
        public Employee(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }
        public override string ToString()
        {
            return $"Employee ID {id}, {firstName} {lastName}";
        }
    }
}