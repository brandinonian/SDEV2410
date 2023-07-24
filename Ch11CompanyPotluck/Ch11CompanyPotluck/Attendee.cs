using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CompanyPotluck
{
    internal class Attendee
    {
        private string firstName;
        private string lastName;
        private string item;

        public Attendee(string firstName, string lastName, string item)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.item = item;
        }

        public string GetFullName() => firstName + " " + lastName;
        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;
        public string GetItem() => item;
        public void SetItem(string item) { this.item = item; }

        public override string ToString() => $"{GetFullName()} is bringing {item}";
    }
}
