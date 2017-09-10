using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentType = Factory.GetInstance("student").GetName();
            var teacherType = Factory.GetInstance("teacher").GetName();
        }
    }
}
