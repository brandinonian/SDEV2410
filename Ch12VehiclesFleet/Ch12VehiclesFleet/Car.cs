using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12VehiclesFleet
{
    internal class Car : Vehicle
    {
        private bool sunroof;

        public Car(string make, string model, string color, string engine, int year, int numDoors, bool sunroof)
            : base(make, model, color, engine, year, numDoors)
        {
            this.sunroof = sunroof;
        }

        public override string ToString()
        {
            string exists;
            if (sunroof)
            {
                exists = "sunroof";
            }
            else
            {
                exists = "no sunroof";
            }
            return base.ToString() + ", " + exists;
        }
    }
}
