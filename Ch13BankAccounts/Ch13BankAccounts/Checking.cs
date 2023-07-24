using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13BankAccounts
{
    internal class Checking : BankAccount
    {
        private double balance;
        private double fee;

        public Checking(int id, string firstName, string lastName, double balance, double fee)
            : base(id, firstName, lastName)
        {
            this.balance = balance;
            this.fee = fee;
        }

        public override string ToString()
        {
            return $"Checking {base.ToString()}, fee: {fee:C}, balance: {balance:C}";
        }

        public override double Debit(double amount)
        {
            // if amount is 0 do not make changes
            if (amount == 0) { return balance; }

            // add fee for withdrawals
            amount += fee;

            // check the balance before subtracting
            if (amount <= balance)
            {
                balance -= amount;

                // display balance
                Console.WriteLine($"After withdrawing {amount:C} the new balance is: {balance:C}");
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
            balance += amount - fee;

            // display balance
            Console.WriteLine($"After depositing {amount:C}, minus fees, the new balance is {balance:C}.");

            return balance;
        }
    }
}
