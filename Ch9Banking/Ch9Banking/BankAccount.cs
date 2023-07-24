internal partial class Program
{
    struct BankAccount
    {
        private int id;
        private string name;
        private decimal balance;
        private decimal fee;

        public BankAccount(int id, string name, decimal balance, decimal fee)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.fee = fee;
        }

        public string DisplayBalance()
        {
            return $"Account {id} for {name}: Balance {balance:C}, fee {fee:C}";
        }

        public void Deposit()
        {
            decimal amount = 0;
            Console.Write("How much would you like to deposit? ");
            try
            {
                amount = decimal.Parse(Console.ReadLine());
                balance += amount - fee;
                Console.WriteLine("Deposit successful");
                Console.WriteLine($"{DisplayBalance()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Operation cancelled");
                Console.WriteLine(ex.Message);
            }
        }

        public void Withdraw()
        {
            decimal amount = 0;
            Console.Write("How much would you like to withdraw? ");
            try
            {
                amount = decimal.Parse(Console.ReadLine());
                if (balance > (amount + fee))
                {
                    balance -= amount + fee;
                    Console.WriteLine("Withdrawal successful");
                    Console.WriteLine($"{DisplayBalance()}");
                }
                else
                {
                    throw new Exception("Insufficient funds");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Operation cancelled");
                Console.WriteLine(ex.Message);
            }
        }
    }
}