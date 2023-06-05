using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//precisamos usar o escopo onde está o nosso enum
using Enumerações.Entities.Enums;

//geralmente iremos utilizar enums para controlar a situação de algo por ser mais prático

namespace Enumerações.Entities
{
    internal class Order
    //esse seria uma representação de uma classe de pedido onde usaremos um enum
    {

        public int Id { get; set; }
        public DateTime Moment { get; set; }

        //aqui usaremos um enum que será para informar a situação do pedido
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"id:{Id}, data:{Moment}, Status:{Status}";
        }

    }
}
