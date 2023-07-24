using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13BankAccounts
{
    abstract class BankAccount
    {
        private int id;
        private string firstName;
        private string lastName;

        public BankAccount(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"{id}: {firstName} {lastName}";
        }

        public abstract double Debit(double amount);

        public abstract double Credit(double amount);
    }
}
