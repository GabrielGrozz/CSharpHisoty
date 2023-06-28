using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //essa seria uma classe sbstrata, de forma rápida, é uma classe que não pode ser instanciada, somente as subclasses podem se instanciadas
    abstract class AbstractPerson
    {
        internal string Name { get; set; }

        public AbstractPerson() { }

        protected AbstractPerson(string name)
        {
            Name = name;
        }
    }
}
