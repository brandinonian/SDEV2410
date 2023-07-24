using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13GreaterThanInterface
{
    internal interface IGreater
    {
        Boolean IsGreater(Object obj);
        void DisplayGreater(Object obj);
    }
}
