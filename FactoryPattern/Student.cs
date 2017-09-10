using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Student : ICommon
    {
        public string GetName()
        {
            return "a student";
        }
    }
}
