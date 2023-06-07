using OrderProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Entities
{
    internal class Order
    {
        DateTime Moment { get; set; }
        OnderStatus Status { get; set; }

        public Order() { }

        public Order(DateTime moment, OnderStatus status)
        {
            Moment = moment;
            Status = status;
        }
    }
}
