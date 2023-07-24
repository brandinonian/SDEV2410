using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Costs
{
    internal class Hardware
    {
        private int partNum;
        private string name;
        private double cost;

        static double salesTax = 0.075;

        public Hardware(int partNum, string name, double cost)
        {
            this.partNum = partNum;
            this.name = name;
            this.cost = cost;
        }

        public string Display()
        {
            return $"{partNum} {name} {cost:C}";
        }

        public double Calculate(ref double subtotal)
        {
            Console.Write("How many sold? ");
            int qty = int.Parse(Console.ReadLine());
            double addCost = qty * (cost * salesTax);
            subtotal = qty * cost;
            return addCost;
        }
    }
}
