using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /*
        The point for Builder Pattern is to seperate the 
        object construction from the representation
    */

    class Program
    {
        static void Main(string[] args)
        {
            var first = new FirstPerson().AddAddress("summer street stamford").Build();
        }
    }
}
