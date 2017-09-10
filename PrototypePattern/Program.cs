using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample mainSample = new Sample();
            Sample clonedSample = mainSample.Clone();
            Sample anotherSample = mainSample;

            mainSample.Name = "changed";

        }
    }
}
