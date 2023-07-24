using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5CompetencyAwards
{
    public abstract class Person
    {
        private string fname;
        private string lname;
        private string stringid;
        private decimal newSales;
        private decimal totalSales;

        public Person(string fname, string lname, string stringid)
        {
            this.fname = fname;
            this.lname = lname;
            this.stringid = stringid;
            newSales = 0;
            totalSales = 0;
        }

        public override string ToString()
        {
            return $"\n{stringid} {fname} {lname}";
        }

        public void SetNewSales()
        {
            bool repeat = false;
            decimal inputSales = 0;
            // ask user for a value, try/catch for format errors
            // loops on exceptions
            do
            {
                repeat = false;
                try
                {
                    Console.Write("Enter monthly sales: ");
                    inputSales = decimal.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    repeat = true;
                    Console.WriteLine(e.Message);
                }
            } while (repeat);

            // assign to newSales, add to totalSales
            // defaults to 0
            totalSales += inputSales;
            newSales = inputSales;
        }

        public decimal GetNewSales() => newSales;

        public decimal GetTotalSales() => totalSales;

        // IAwards interface
        public abstract decimal ProcessAwards(int month);
    }
}
