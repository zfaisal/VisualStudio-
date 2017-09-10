using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Factory
    {
        public static ICommon GetInstance(string type)
        {
            ICommon common = null; 
            if (type == "student")
            {
                common =  new Student();
            }
            else
            {
                common = new Teacher(); 
            }
            return common;
        }
    }
}
