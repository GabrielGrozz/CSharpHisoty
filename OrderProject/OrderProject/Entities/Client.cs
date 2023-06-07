using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Entities
{
    internal class Client
    {
        string Name { get; set; }
        string Email { get; set; }
        DateTime BirthDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
