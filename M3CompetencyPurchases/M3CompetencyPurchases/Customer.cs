internal partial class Program
{
    struct Customer
    {
        private string firstName;
        private string lastName;
        private int id;
        public Customer (string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }
        public override string ToString()
        {
            return $"Customer {id}, {firstName} {lastName}";
        }
    }
}