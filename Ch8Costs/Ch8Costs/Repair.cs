using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Costs
{
    internal class Repair
    {
        private string ticketNum;
        private string name;
        private double cost;

        static double salesTax = 0.045;
        static double markup = 0.1;

        public Repair(string ticketNum, string name, double cost)
        {
            this.ticketNum = ticketNum;
            this.name = name;
            this.cost = cost;
        }

        public string Display()
        {
            return $"{ticketNum} {name} {cost:C}";
        }

        public double Calculate(ref double subtotal)
        {
            double addCost = (cost * salesTax) + (cost * markup);
            subtotal = cost;
            return addCost;
        }
    }
}
