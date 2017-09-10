using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class BuilderAbstract
    {
        protected string Name { get; set; }
        protected string Address { get; set; }

        public BuilderAbstract AddName(string value)
        {
            this.Name = value;
            return this;
        }


        public BuilderAbstract AddAddress(string value)
        {
            this.Address = value;
            return this;
        }


        public Person Build()
        {
            return new Person(this.Name, this.Address); 
        }
    }
}
