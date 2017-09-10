using designPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = (new Calculator()).GetNumber(3, new BigNumber()); 
        }
    }
}
