using OrderProject.Entities.Enums;
using System.Text;
using OrderProject;
using System.Text.RegularExpressions;

namespace OrderProject.Entities
{
    internal class Order
    {
        DateTime Moment { get; set; }
        OrderStatus Status { get; set; }
        //lista com os pedidos
        List<OrderItem> items { get; set; } = new List<OrderItem>();
        Client OrderClient;

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            OrderClient = client;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);

        }

        //achq o total de todos os pedidos juntos
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in items)
            {
                total += item.subTotal();
            }

            return total;
        }

        //override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {OrderClient.Name} ({OrderClient.BirthDate.Date.ToShortDateString()}) - {OrderClient.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in items)
            {
                sb.AppendLine($"{item.ProductItem.Name}, {item.ProductItem.Price}, Quantity: {item.Quantity}, Subtotal: {item.subTotal()}");
            }
            sb.AppendLine($"Total price: ${Total()}");

            return sb.ToString();
        }
    }
}
