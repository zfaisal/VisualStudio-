using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    internal class Calculator
    {
        public int GetNumber(int num, INumber classType)
        {
            return classType.GetNumber(num); 
        }
    }
}
