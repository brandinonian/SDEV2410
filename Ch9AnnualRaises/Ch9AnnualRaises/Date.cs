using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9AnnualRaises
{
    internal class Date
    {
        private int month;
        private int day;
        private int year;

        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }

        public override string ToString()
        {
            Months monthName = (Months)month;
            return $"{monthName} {day}, {year}";
        }

        public int GetYear() => year;
    }
}
