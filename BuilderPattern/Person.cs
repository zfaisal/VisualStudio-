using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
            
        }
    }
}
