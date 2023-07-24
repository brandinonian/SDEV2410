using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5CompetencyAwards
{
    public class SalesRep : Person
    {
        // commission rate, stored as an int to represent a percentage
        private int comRate;
        private decimal quota;

        public SalesRep(string fname, string lname, string stringid, int comRate, decimal quota)
            : base(fname, lname, stringid)
        {
            this.comRate = comRate;
            this.quota = quota;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, commission rate: {comRate}%, sales: {base.GetTotalSales():C}, quota: {quota:C}";
        }

        // calculate commission based on new monthly sales
        // s = new monthly sales
        public decimal CalcCommission(decimal s)
        {
            // calculate commission with percentage rate
            return s * (comRate * .01m);
        }

        // IAwards interface
        // sales rep award is a $500 bonus if they reach their quota for the month
        public override decimal ProcessAwards(int month)
        {
            if (base.GetNewSales() >= this.quota)
            {
                return 500m;
            }
            else
            {
                Console.WriteLine("Quota not met, no bonus...");
                return 0m;
            }
        }
    }
}
