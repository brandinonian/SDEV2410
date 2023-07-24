using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12VehiclesFleet
{
    internal class Truck : Vehicle
    {
        private int bedLength;
        private bool bedLiner;

        public Truck(string make, string model, string color, string engine, int year, int numDoors, int bedLength, bool bedLiner)
            : base(make, model, color, engine, year, numDoors)
        {
            this.bedLength = bedLength;
            this.bedLiner = bedLiner;
        }

        public override string ToString()
        {
            string exists;
            if (bedLiner)
            {
                exists = "bed liner";
            }
            else
            {
                exists = "no bed liner";
            }
            return base.ToString() + $", bed length {bedLength}, " + exists; 
        }
    }
}
