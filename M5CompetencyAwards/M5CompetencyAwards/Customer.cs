using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5CompetencyAwards
{
    public class Customer : Person
    {
        private int birthMonth;

        public Customer(string fname, string lname, string stringid, int birthMonth)
            : base(fname, lname, stringid)
        {
            this.birthMonth = birthMonth;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, birth month: {birthMonth}, sales: {base.GetTotalSales():C}";
        }

        // IAwards interface
        // customer gets 10% cash back on sales during their birthday month
        // returns the bonus amount, 0 if not customers birthday month
        public override decimal ProcessAwards(int month)
        {
            if (this.birthMonth == month)
            {
                decimal bonus = base.GetNewSales() * .1m;
                return bonus;
            }
            else
            {
                Console.WriteLine("Cash back bonus only applied during birthday month...");
                return 0m;
            }
        }
    }
}
