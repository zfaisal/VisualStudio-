using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Sample
    {
        public string Name = "yes";

        public Sample Clone()
        {
            return (Sample)this.MemberwiseClone(); 
        }
    }
}
