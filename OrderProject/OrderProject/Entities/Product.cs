using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Entities
{
    internal class Product
    {
        int Name { get; set; }
        double Price { get; set; }

        public Product() { }

        public Product(int name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
