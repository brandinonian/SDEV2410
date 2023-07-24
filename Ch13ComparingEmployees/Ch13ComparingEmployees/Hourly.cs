using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13ComparingEmployees
{
    class Hourly : Employee
    {
        public Hourly(string id, string firstName, string lastName, decimal payRate)
            : base(id, firstName, lastName, payRate)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}, hourly pay {base.GetPayRate():C}, annual pay {base.GetPayRate() * 2080:C}";
        }
    }
}
