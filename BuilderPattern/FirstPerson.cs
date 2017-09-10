using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class FirstPerson : BuilderAbstract
    {
        public FirstPerson()
        {
            this.AddName("zaki");
            
        }
    }
}
