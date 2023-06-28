using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Employee : AbstractPerson
    {
        public string Work { get; set; }
        public Employee() { }
        public Employee(string name, string work) : base(name)
        {
            Work = work;
        }


    }
}
