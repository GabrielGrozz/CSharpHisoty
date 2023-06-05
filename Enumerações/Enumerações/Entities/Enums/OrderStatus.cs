using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerações.Entities.Enums
{
    //essa seria a declaração de um enum
    enum OrderStatus : int
    {

        //caso não passemos um valor, ele irá declarar o valor como 0 por padrão.
        PendingPayment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
