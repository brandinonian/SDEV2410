using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13ComparingEmployees
{
    class Salaried : Employee
    {
        public Salaried(string id, string firstName, string lastName, decimal payRate)
            : base(id, firstName, lastName, payRate)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()}, salary {base.GetPayRate():C}";
        }
    }
}
