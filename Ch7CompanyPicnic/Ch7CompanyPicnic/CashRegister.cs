using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7CompanyPicnic
{
    internal class CashRegister
    {
        public static double grandTotalSales = 0;

        private double totalSales;
        public CashRegister()
        {
            totalSales = 0;
        }

        public double NewSale(double cost, double cash)
        {
            if (cost > cash) { throw new Exception("No sale, you didn't pay enough"); }
            else
            {
                totalSales += cost;
                grandTotalSales += cost;
                return cash - cost;
            }
        }

        public double GetTotalSales() => totalSales;
    }
}
