using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13BankAccounts
{
    internal class CreditCard : BankAccount
    {
        private double balance;
        private double limit;

        public CreditCard(int id, string firstName, string lastName, double balance, double limit)
            : base(id, firstName, lastName)
        {
            this.balance = balance;
            this.limit = limit;
        }

        public override string ToString()
        {
            return $"Credit Card {base.ToString()}, balance owed: {balance:C}, credit limit: {limit:C}";
        }
        public override double Credit(double amount)
        {
            // if amount is 0 do not make changes
            if (amount == 0) { return balance; }

            // check the balance before subtractring payments
            if (amount <= balance)
            {
                balance -= amount;

                // display balance
                Console.WriteLine($"After payment of {amount:C} the new balance is: {balance:C}");
            }
            else
            {
                Console.WriteLine("Cannot pay more than the outstanding balance...");
            }
            return balance;
        }

        public override double Debit(double amount)
        {
            // if amount is 0 do not make changes
            if (amount == 0) { return balance; }

            // check credit limit before adding charges
            if ((balance + amount) <= limit)
            {
                balance += amount;

                // display balance
                Console.WriteLine($"After charging {amount:C} the new balance is: {balance:C}.");
            }
            else
            {
                Console.WriteLine("Charge exceeds credit limit...");
            }
            return balance;
        }
    }
}
