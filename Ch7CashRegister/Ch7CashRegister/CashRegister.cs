using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch7CashRegister
{
    class CashRegister
    {
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
                return cash - cost;
            }
        }

        public void DisplayTotalSales()
        {
            WriteLine($"\nTotal Sales: {totalSales:C}");
        }               
    }
}
