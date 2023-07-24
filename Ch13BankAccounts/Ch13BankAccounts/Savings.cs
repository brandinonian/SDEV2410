using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13BankAccounts
{
    internal class Savings : BankAccount
    {
        private double balance;
        private double interest;

        public Savings(int id, string firstName, string lastName, double balance, double interest)
            : base(id, firstName, lastName)
        {
            this.balance = balance;
            this.interest = interest;
        }

        public override string ToString()
        {
            return $"Savings {base.ToString()}, interest rate: {interest}%, balance: {balance:C}";
        }

        public override double Debit(double amount)
        {
            // if amount is 0 do not make changes
            if (amount == 0) { return balance; }

            // process withdrawal
            if (amount <= balance)
            {
                balance -= amount;

                // display balance
                Console.WriteLine($"After withdrawing {amount:C} the new balance is: {balance:C}.");
            }
            else
            {
                Console.WriteLine("Not enough funds...");
            }
            return balance;
        }

        public override double Credit(double amount)
        {
            // if amount is 0 do not make changes
            if (amount == 0) { return balance; }

            // add interest on deposits
            balance += amount;
            balance += balance * (interest * .01);           

            // display balance
            Console.WriteLine($"After credit of {amount:C}, after interest, new balance is: {balance:C}.");

            return balance;
        }
    }
}
