using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7BirthdayBonus
{
    internal class Date
    {
        private int day; private int year; private int month;

        public Date(int month, int day, int year)
        {
            this.day = day;
            this.year = year;
            this.month = month;
        }

        public int getDay() { return day; }
        public int getYear() { return year; }
        public int getMonth() { return month; }

        public string getDate() { return month + "/" + day + "/" + year; }

        public void setDay(int day) {  this.day = day; }
        public void setYear(int year) {  this.year = year; }
        public void setMonth(int month) {  this.month = month; }

    }
}
