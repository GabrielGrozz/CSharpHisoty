using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Entities
{
    internal class OrderItem
    {
        int Quantity { get; set; }
        double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
    }
}
