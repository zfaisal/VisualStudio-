using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Teacher : ICommon
    {
        public string GetName()
        {
            return "a teacher";
        }
    }
}
