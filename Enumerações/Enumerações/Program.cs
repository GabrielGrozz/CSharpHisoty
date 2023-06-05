//---------ENUMERAÇÕES---------

//é um tipo que serve para específicar de forma literal um conjunto de constantes relacionadas
//usamoso o enum para referenciar ele
using Enumerações.Entities;
using Enumerações.Entities.Enums;
using System.Runtime.CompilerServices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui instanciamos um pedido passando os valores
            Order novoPedido = new Order()
            {
                Id = 155,
                Moment = DateTime.Now,
                //aqui usamos o enum do OrderStatus
                //ele é auxiliado pelo compilador na hora de selecionarmos o status
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(novoPedido);

            //caso precissemos do enum em string podemos converter para string
            String statusString = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(statusString);

            //podemos tambèm converter uma string para um tipo enumerado tambèm dessa forma
            //colocamos o tipo do enum entre os <> e parametrizamos o valor que queremos
            OrderStatus novoStatus = Enum.Parse<OrderStatus>("Shipped");
            Console.WriteLine(novoStatus);

        }
    }
}